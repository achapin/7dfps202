using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevelZone : MonoBehaviour
{
    [SerializeField] private string levelToLoad;
    
    private List<GameObject> badGuysInZone = new List<GameObject>();
    private bool playerInZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.GetComponentInChildren<BadGuyHealthController>() != null)
        {
            Debug.Log("Bad guy added to zone");
            badGuysInZone.Add(other.transform.parent.gameObject);
        }

        if (other.transform.parent.GetComponentInChildren<PlayerHealth>() != null)
        {
            Debug.Log("Player Entered win zone");
            SceneManager.LoadScene(levelToLoad);
            //playerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.GetComponentInChildren<BadGuyHealthController>() != null)
        {
            badGuysInZone.Add(other.transform.parent.gameObject);
        }

        if (other.transform.parent.GetComponentInChildren<PlayerHealth>() != null)
        {
            Debug.Log("Player Left win zone");
            playerInZone = false;
        }
    }

    void Update()
    {
        if (playerInZone)
        {
            int badGuysLeft = 0;
            foreach (var badGuy in badGuysInZone)
            {
                if (badGuy.GetComponent<BadGuyHealthController>().health > 0f)
                {
                    badGuysLeft++;
                }
            }

            if (badGuysLeft <= 0)
            {
                SceneManager.LoadScene(levelToLoad);
            }
            else
            {
                Debug.Log($"Bad guys left {badGuysLeft}");
            }
        }
    }
}
