using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float health;

    [SerializeField] private Image healthImage;
    [SerializeField] private Image FadeToBlackImage;
    [SerializeField] private float deathPonderTime;
    [SerializeField] private float fadeTime;

    [SerializeField] private float invincibleTime;

    private float startHealth;
    private float takenDamageTime;
    
    void Start()
    {
        startHealth = health;
        takenDamageTime = Time.timeSinceLevelLoad;
    }
    
    void Update()
    {
        healthImage.fillAmount = health / startHealth;
    }

    public void TakeDamage(float amount)
    {
        if(health <= 0f || Time.timeSinceLevelLoad < takenDamageTime + invincibleTime) return;
        health -= amount;
        takenDamageTime = Time.timeSinceLevelLoad;
        if (health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<PlayerControls>().enabled = false;
        GetComponent<ShootingControls>().enabled = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        StartCoroutine(FadeToBlack());
    }

    private IEnumerator FadeToBlack()
    {
        yield return new WaitForSeconds(deathPonderTime);
        Color startColor = Color.black;
        startColor.a = 0f;
        float currentTime = 0f;
        while (currentTime < fadeTime)
        {
            FadeToBlackImage.color = Color.Lerp(startColor, Color.black, currentTime / fadeTime);
            currentTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        FadeToBlackImage.color = Color.black;
    }
}
