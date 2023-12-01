using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int hp;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerFireball"))
        {
            hp -= 1;
        }
    }
}

