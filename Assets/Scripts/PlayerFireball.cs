using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFireball : MonoBehaviour
{
    public Vector3 target;
    private float timer;
    private float originalTimer;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
        originalTimer = 10;
        timer = originalTimer;
        target = enemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            gameObject.SetActive(false);
        }
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 0.03f);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.SetActive(false);
    }
}
// make a different script for the player making fireballs
// use this
//     private void OnMouseDown()
// {
//    if (Input.GetMouseButton(1))
//       {
//        
//       }
// }