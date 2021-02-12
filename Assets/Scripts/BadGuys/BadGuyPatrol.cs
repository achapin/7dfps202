using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(NavMeshAgent))]
public class BadGuyPatrol : BadGuyAIState
{

    [SerializeField] private float patrolSpeed;
    [SerializeField] private Transform initalPatrolLocation;
    [SerializeField] private float patrolRange = 10f;
    [SerializeField] private float totalSeeTimeToTransition;

    private float seePercentage;
    
    public override void EnterState()
    {
        base.EnterState();
        sight.SourceTarget = GameObject.Find("Player");
        
        sight.SourceTarget.GetComponent<EnemyDetector>().AddIndicatorFor(gameObject);
        
        myAgent.speed = patrolSpeed;
        seePercentage = 0f;
        if(initalPatrolLocation == null)
        {
            SetNewLocation();
        }
        else
        {
            myAgent.SetDestination(initalPatrolLocation.position);
        }
    }
    void Update()
    {
        if(!activeState) return;

        if (sight.CanSeeTarget(out float percentage))
        {
            seePercentage += Time.deltaTime * percentage;
            if(seePercentage >= totalSeeTimeToTransition)
            {
                Controller.ChangeToState(GetComponent<BadGuyAttackState>());
            }
        }
        else
        {
            seePercentage = Mathf.Clamp(seePercentage - Time.deltaTime, 0f, totalSeeTimeToTransition);
        }
        
        if (myAgent.remainingDistance <= Mathf.Epsilon)
        {
            SetNewLocation();
        }
    }

    public float DiscoveryPercentage()
    {
        return seePercentage / totalSeeTimeToTransition;
    }

    private void SetNewLocation()
    {
        if(!myAgent.pathPending)
        {
            Vector3 offset = new Vector3(Random.Range(-patrolRange, patrolRange), 0f, Random.Range(-patrolRange, patrolRange));
            myAgent.SetDestination(transform.position + offset);
        }
    }

    private void OnDrawGizmos()
    {
        if(myAgent != null)
        {
            Debug.DrawLine(transform.position, myAgent.destination, Color.green);
        }
    }
}
