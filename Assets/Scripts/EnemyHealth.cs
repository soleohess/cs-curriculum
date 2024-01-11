using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyHealth : MonoBehaviour
{
    public GameObject coin;
    public GameObject healthPotion;
    public int hp;
    [SerializeField] private float randomNumber;
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

        if (hp <= 0)
        {
            randomNumber = Random.Range(0, 10);
            if (randomNumber < 3)
            {
                Instantiate(coin, transform.position, transform.rotation);
            }
            else if (randomNumber > 3 && randomNumber < 6)
            {
                Instantiate(healthPotion, transform.position, transform.rotation);
            }
            else if (randomNumber > 6)
            {
                //do nothing
            }
        }    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("PlayerFireball"))
        {
            hp -= 1;
        }
    }
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerFireball"))
        {
            hp -= 1;
        }
    }*/
}

