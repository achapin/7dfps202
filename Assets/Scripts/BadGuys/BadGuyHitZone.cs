using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyHitZone : MonoBehaviour
{
    [SerializeField] public BadGuyHealthController healthController;

    [SerializeField] private float healthTakenOnHit = default;

    public void TakeDamage(float damage, Vector3 sourcePosition)
    {
        healthController?.TakeDamage(healthTakenOnHit * damage, sourcePosition);
    }
}