
using UnityEngine;

public class BadGuyDeadState : BadGuyAIState
{
    public override void EnterState()
    {
        base.EnterState();
        myAgent.enabled = false;
        var rb = gameObject.AddComponent<Rigidbody>();
        rb.mass = 15f;
        rb.angularVelocity = transform.right * -5f;
    }
}
