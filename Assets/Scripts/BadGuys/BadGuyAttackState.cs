using System;
using UnityEngine;

public class BadGuyAttackState : BadGuyAIState
{
    [SerializeField] private float timeToFire;
    [SerializeField] private float minAngleToFire;
    [SerializeField] private float timeToForget;
    [SerializeField] private float targetDistance;
    [SerializeField] private float pursueSpeed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private Vector3 armRotationRest;
    [SerializeField] private Transform FireArm;
    [SerializeField] private int shotsBeforeReload;
    [SerializeField] private float timeToReload;
    
    private float lastSeenTime;
    private float timeLastFired;
    private Vector3 lastSeenPosition;
    private int shotNumber;
    
    public override void EnterState()
    {
        base.EnterState();
        
        myAgent.speed = pursueSpeed;
        myAgent.SetDestination(transform.position);
        
        sight.SourceTarget = GameObject.Find("Player");
        lastSeenTime = Time.timeSinceLevelLoad;
        timeLastFired = Time.timeSinceLevelLoad;
    }

    public override void ExitState()
    {
        base.ExitState();
        FireArm.transform.rotation = Quaternion.Euler(armRotationRest);
        myAgent.updateRotation = true;
    }

    void Update()
    {
        if(!activeState) return;
        Vector3 towardsTarget = sight.SourceTarget.transform.position - transform.position;
        towardsTarget.y = 0f;

        var targetAngle = Vector3.Angle(transform.forward, towardsTarget);
        lastSeenPosition = sight.SourceTarget.transform.position;
        
        if (sight.CanSeeTarget(out _))
        {
            myAgent.updateRotation = false;
            lastSeenTime = Time.timeSinceLevelLoad;
            if (targetAngle < minAngleToFire)
            {
                var distance = towardsTarget.magnitude;
                var heightDifference = sight.SourceTarget.transform.position.y - transform.position.y;
                var targetAimAngle = Mathf.Rad2Deg * Mathf.Atan2(heightDifference, distance);
                FireArm.transform.localRotation = Quaternion.Euler(Vector3.left * targetAimAngle);
                if (Time.timeSinceLevelLoad > timeLastFired + timeToFire)
                {
                    Fire();
                }
            }
            else
            {
                FireArm.transform.localRotation = Quaternion.Euler(armRotationRest);
            }

            Vector3 newOrientation = Vector3.RotateTowards(transform.forward, towardsTarget.normalized,
                360f * Time.deltaTime, Single.MaxValue);

            transform.forward = newOrientation;

            if (myAgent.isStopped || myAgent.remainingDistance <= 1f)
            {
                if(towardsTarget.magnitude > targetDistance)
                {
                    myAgent.SetDestination(transform.position + towardsTarget.normalized * targetDistance);
                }
            }
        }
        else
        {
            myAgent.updateRotation = true;
            if (Time.timeSinceLevelLoad > lastSeenTime + timeToForget)
            {
                Controller.ChangeToState(gameObject.GetComponent<BadGuyPatrol>());
            }
            
            if (myAgent.isStopped || myAgent.remainingDistance <= 1f)
            {
                myAgent.SetDestination(lastSeenPosition);
            }
        }
    }

    private void Fire()
    {
        var newBullet = Instantiate(bullet, FirePoint.position, FirePoint.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = FireArm.transform.forward * bulletSpeed;
        timeLastFired = Time.timeSinceLevelLoad;
        shotNumber++;
        if (shotNumber >= shotsBeforeReload)
        {
            timeLastFired += timeToReload - timeToFire;
            shotNumber = 0;
        }
    }
}
