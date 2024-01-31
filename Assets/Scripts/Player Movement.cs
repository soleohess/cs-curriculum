using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool overworld;
    private float xdirection;
    private float xSpeed;
    private float ySpeed;
    private float xvector;
    private float yvector;
    private float ydirection;
    public Rigidbody2D rb;
    private bool atj;
    // Start is called before the first frame update
    void Start()
    {
        if (!overworld)
        {
            ySpeed = 0;
        }
        else
        {
            ySpeed = 5;
        }
        xSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        xdirection = Input.GetAxis("Horizontal");
        ydirection = Input.GetAxis("Vertical");
        
        xvector = xdirection*xSpeed*Time.deltaTime;
        yvector = ydirection*ySpeed*Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, yvector, 0);
        /*if (!overworld)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                
            }
        }*/
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        atj == true;
        if (!overworld)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            }
        }

        
    }
}
