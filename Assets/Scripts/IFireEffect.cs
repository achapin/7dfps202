using UnityEngine;

public abstract class IFireEffect : MonoBehaviour
{
    public virtual bool ShouldSpawnPerBullet => false;
    public virtual void Fire(Transform startPosition, Vector3 endPosition) { }
}
