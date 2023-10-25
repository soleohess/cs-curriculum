using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Reporting;
using UnityEditor.Purchasing;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int coins;
    public int health;
    public int maxHealth;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    //Awake is called before the first start
    private void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health " + health;
        coinText.text = "Coins: " + coins;
    }
}
