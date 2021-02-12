using UnityEngine;
using UnityEngine.InputSystem;

public class BadGuySight : MonoBehaviour
{
    [SerializeField] private float minAngleToSee;
    [SerializeField] private LayerMask sightMask;
    [SerializeField] private float sightDistance;

    public GameObject SourceTarget;

    private Transform myTransform;

    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    public bool CanSeeTarget(out float dotProduct)
    {
        dotProduct = 0f;
        if (SourceTarget == null) return false;

        Vector3 towardsTarget = SourceTarget.transform.position - myTransform.position;
        var targetAngle = Vector3.Angle(myTransform.forward, towardsTarget);
        dotProduct = Vector3.Dot(myTransform.forward, towardsTarget);

        Debug.DrawRay(transform.position + Vector3.up, towardsTarget * 100f,
            targetAngle < minAngleToSee ? Color.red : Color.green);

        if (targetAngle < minAngleToSee)
        {
            if (Physics.Raycast(transform.position + transform.up, towardsTarget, out RaycastHit hit, sightDistance, sightMask,
                QueryTriggerInteraction.Ignore))
            {
                if (hit.collider.attachedRigidbody == null) return false;
                return hit.collider.attachedRigidbody.gameObject.TryGetComponent<PlayerInput>(out _);
            }
        }

        return false;
    }
}