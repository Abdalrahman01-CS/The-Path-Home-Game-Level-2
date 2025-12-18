using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbdelrahmanPlayerStats : MonoBehaviour
{
    public Image greenHealthBar;
    public static int health = 3;
    public static int maxHealth = 3;
    public static int lives = 3;
    public static int score = 0;
    public static bool hasHeart = false;

    private float flickerTime = 0f;
    public float flickerDuration = 0.1f;

    private SpriteRenderer sr;

    public bool isImmune = false;
    private float immunityTime = 0f;
    public float immunityDuration = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isImmune == true)
        {
            SpriteFlicker();

            immunityTime += Time.deltaTime;

            if(immunityTime >= immunityDuration)
            {
                isImmune = false;
                sr.enabled = true;
            }
        }
        
    }

    void SpriteFlicker()
    {
        if(flickerTime < flickerDuration)
        {
            flickerTime += Time.deltaTime;
        }

        else if(flickerTime >= flickerDuration)
        {
            sr.enabled = !(sr.enabled);
            flickerTime = 0f;
        }
    }

    public void TakeDamage(int damage)
    {
        if(isImmune == false)
        {
            health -= damage;
            greenHealthBar.fillAmount = AbdelrahmanPlayerStats.health/3f;

            if(health < 0)
                health = 0;

            if(lives > 0 && health == 0)
            {
                FindObjectOfType<Level2Manager>().RespawnPlayer();
                health = 3;
                greenHealthBar.fillAmount = AbdelrahmanPlayerStats.health/3f;
                lives--;
            }

            else if(lives == 0 && health == 0)
            {
                greenHealthBar.fillAmount = 0f;
                Debug.Log("Gameover");
                Destroy(this.gameObject);
            }

            Debug.Log("Palyer Health:" + health.ToString());
            Debug.Log("Palyer Lives:" + lives.ToString());
        }

        isImmune = true;
        immunityTime = 0f;
    }

    public void Heal(int amount)
{
    health += amount;
    greenHealthBar.fillAmount = AbdelrahmanPlayerStats.health/3f;

    if (health > maxHealth)
    {
        health = maxHealth;
        greenHealthBar.fillAmount = 1f;
    }

    Debug.Log("Player healed. Health: " + health);
}
}
