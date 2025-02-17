using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class PlayerFireball : MonoBehaviour
{
    public GameObject target;
    public float timer;
    private float originalTimer;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        originalTimer = 5;
        timer = originalTimer;
        target = null;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //target = GameObject.FindGameObjectWithTag("Enemy");
        /*if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject = target;

            // Target needs to be set properly
            //target = other.gameObject;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Enemy");
        timer -= Time.deltaTime;
        if (timer<0)
        {
            Destroy(self);
        }

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.02f);
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(self.gameObject);
    }
}
