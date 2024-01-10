using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{   
    private float timer;
    private float originalTimer;
    private GameObject target;
    public Vector3 offset;
    public int hp;
    [SerializeField] private GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        originalTimer = 3;
        timer = originalTimer;
        hp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                Instantiate(projectile, transform.position + offset, quaternion.identity);
                timer = originalTimer;
            }
        }

        if (hp <= 0)
        {
            this.gameObject.SetActive(false);   
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject;
        }
        else if (other.gameObject.CompareTag("PlayerFireball"))
        {
            hp -= 1;
            Debug.Log("string");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = null;
        }
    }

}