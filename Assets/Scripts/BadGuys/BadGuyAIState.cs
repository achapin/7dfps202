using UnityEngine;
using UnityEngine.AI;

public abstract class BadGuyAIState : MonoBehaviour
{
    [HideInInspector]
    public BadGuyAIController Controller;
    [HideInInspector]
    public NavMeshAgent myAgent;
    [HideInInspector]
    public BadGuySight sight;

    protected bool activeState;
    public bool IsActiveState => activeState;

    public virtual void EnterState()
    {
        activeState = true;
    }

    public virtual void ExitState()
    {
        activeState = false;
    }
}
