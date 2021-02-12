using UnityEngine;
using UnityEngine.AI;

public class BadGuyHealthController : MonoBehaviour
{
    public float health;

    [SerializeField] private GameObject bloodEffect;

    private BadGuyAIController aiController;

    void Start()
    {
        aiController = GetComponent<BadGuyAIController>();
    }

    public void TakeDamage(float damage, Vector3 hitPosition)
    {
        if (health > 0f)
        {
            Instantiate(bloodEffect, hitPosition, Quaternion.identity);
        }
        
        health -= damage;
        if (health <= 0f)
        {
            Die();
        }else
        {
            aiController.ChangeToState(GetComponent<BadGuyAttackState>());
        }
    }

    private void Die()
    {
        GetComponent<BadGuyAIController>().ChangeToState(gameObject.GetComponent<BadGuyDeadState>());
    }
}
