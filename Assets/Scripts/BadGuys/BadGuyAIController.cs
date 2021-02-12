using UnityEngine;
using UnityEngine.AI;

public class BadGuyAIController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;

    private BadGuyAIState currentState;

    void Start()
    {
        foreach (var aiState in GetComponentsInChildren<BadGuyAIState>())
        {
            aiState.Controller = this;
            aiState.myAgent = navMeshAgent;
            aiState.sight = GetComponent<BadGuySight>();
        }
        ChangeToState(GetComponent<BadGuyPatrol>());
    }

    public void ChangeToState(BadGuyAIState newState)
    {
        if(newState == currentState) return;
        currentState?.ExitState();
        currentState = newState;
        currentState.EnterState();
    }
}
