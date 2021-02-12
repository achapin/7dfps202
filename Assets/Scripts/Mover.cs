using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private Vector3 pointA;
    [SerializeField]
    private Vector3 pointB;

    [SerializeField] private float travelTime;
    [SerializeField] private float restTime;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Go());
    }

    private IEnumerator Go()
    {
        while (true)
        {
            yield return Goto(pointB);
            yield return new WaitForSeconds(restTime);
            yield return Goto(pointA);
            yield return new WaitForSeconds(restTime);
        }
    }

    private IEnumerator Goto(Vector3 position)
    {
        float time = 0f;
        Vector3 startPos = transform.position;
        while (time < travelTime)
        {
            transform.position = Vector3.Lerp(startPos, position, time / travelTime);
            time += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = position;
    }
}
