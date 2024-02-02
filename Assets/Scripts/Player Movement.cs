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
    public float jumpforce;
    public Rigidbody2D rb;
    public LayerMask ground;

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

        xvector = xdirection * xSpeed * Time.deltaTime;
        yvector = ydirection * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, yvector, 0);
        if (!overworld)
        { 
            atj = Physics2D.Raycast(transform.position, Vector2.down, 1, ground);
            Debug.DrawRay(transform.position, Vector2.down, Color.red);
            if (atj && Input.GetKeyDown("space"))
            {
                rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);

            }
        }
    }
}