using UnityEngine;

public class Blaster : MonoBehaviour
{
    public Transform firePoint;
    public IFireEffect FireEffect;
    public float timeToFire;
    public bool isAutomatic;
    public bool IsHitScan;
    public float hitDamage;
    public float varianceDistance;
    public float varianceAmount;
    public int bulletsPerShot;
    public Sprite crosshairImage;

    private float lastFireTime;
    private bool isFiring;

    void Start()
    {
        FireEffect.gameObject.SetActive(false);
    }

    public bool StartFire()
    {
        if (lastFireTime + timeToFire < Time.timeSinceLevelLoad)
        {
            isFiring = true;
            lastFireTime = Time.timeSinceLevelLoad;
            if (!isAutomatic)
            {
                Fire();
            }
            return true;
        }

        return false;
    }

    void Update()
    {
        if (isFiring && isAutomatic)
        {
            if (lastFireTime + timeToFire < Time.timeSinceLevelLoad)
            {
                lastFireTime = Time.timeSinceLevelLoad;
                Fire();
            }
        }
    }

    public void StopFire()
    {
        isFiring = false;
    }

    public float FirePercentage()
    {
        return Mathf.Clamp01((Time.timeSinceLevelLoad - lastFireTime) / timeToFire);
    }

    private void Fire()
    {
        if (IsHitScan)
        {
            for (int bulletIndex = 0; bulletIndex < bulletsPerShot; bulletIndex++)
            {
                FireHitScanBullet();
            }
        }
        //TODO: Implement non-hitscan blaster effects!
    }

    private void FireHitScanBullet()
    {
        var variancePoint = firePoint.position 
                            + firePoint.forward * this.varianceDistance 
                            + UnityEngine.Random.insideUnitSphere * varianceAmount;
        
        var fireRay = new Ray(firePoint.position, variancePoint - firePoint.position);
        
        Debug.DrawRay(fireRay.origin, fireRay.direction, Color.yellow);

        IFireEffect effectInstance = FireEffect;
        if(FireEffect.ShouldSpawnPerBullet)
        {
            effectInstance = Instantiate(FireEffect.gameObject, firePoint.position, firePoint.rotation).GetComponent<IFireEffect>();
            effectInstance.gameObject.SetActive(true);
        }
        
        if (Physics.Raycast(fireRay, out RaycastHit hit, varianceDistance))
        {
            Debug.DrawLine(firePoint.position, hit.point, Color.red, 1f);
            effectInstance?.Fire(firePoint, hit.point);
            if (hit.collider.gameObject.TryGetComponent(out BadGuyHitZone hitZone))
            {
                hitZone.TakeDamage(hitDamage, hit.point);
            }
        }
        else
        {
            effectInstance?.Fire(firePoint, firePoint.position + fireRay.direction * varianceDistance);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        if (firePoint == null)
        {
            return;
        }
        var variancePoint = firePoint.position + firePoint.forward * varianceDistance;
        Gizmos.DrawLine(firePoint.position, variancePoint);
        Gizmos.DrawLine(firePoint.position, variancePoint + firePoint.up * varianceAmount);
        Gizmos.DrawLine(firePoint.position, variancePoint + firePoint.up * -varianceAmount);
        Gizmos.DrawLine(firePoint.position, variancePoint + firePoint.right * varianceAmount);
        Gizmos.DrawLine(firePoint.position, variancePoint + firePoint.right * -varianceAmount);
    }
}
