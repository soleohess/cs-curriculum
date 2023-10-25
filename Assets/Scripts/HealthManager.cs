using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private bool iframes;
    private float Timer;
    private float originalTimer;
    private HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        originalTimer = 1;
        Timer = originalTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (iframes)
        {
            Timer -= Time.deltaTime;
            if (Timer<0)
            {
                iframes = false;
                Timer = originalTimer;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-1);
        }

        if (other.gameObject.CompareTag("FireBall"))
        {
            ChangeHealth(-4);
            other.gameObject.SetActive(false);
        }
    }


    void ChangeHealth(int amount)
    {
        if (!iframes)
        {
            iframes = true;
            hud.health += amount;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HealthPotion"))
        {
            if (hud.health < hud.maxHealth)
            {
                ChangeHealth(3);
                if (hud.health > hud.maxHealth)
                {
                    hud.health = hud.maxHealth;
                }

                other.gameObject.SetActive(false);
            }
        }
    }
}
