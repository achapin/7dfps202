using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneInTime : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private String scene;
    
    void Start()
    {
        StartCoroutine(MoveToSceneInTime());
    }

    private IEnumerator MoveToSceneInTime()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scene);
    }
}
