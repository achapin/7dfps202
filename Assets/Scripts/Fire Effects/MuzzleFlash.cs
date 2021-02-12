using System.Collections;
using UnityEngine;

public class MuzzleFlash : IFireEffect
{
    [SerializeField] private GameObject flashObject;
    [SerializeField] private float showTime;
    [SerializeField] private ParticleSystem particleSystem;
    public override void Fire(Transform startPosition, Vector3 endPosition)
    {
        gameObject.SetActive(true);
        flashObject.SetActive(true);
        flashObject.transform.localRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
        particleSystem.Emit(Random.Range(10, 20));
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        float time = 0f;
        yield return new WaitForSeconds(showTime);
        flashObject.SetActive(false);
    }
}
