using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 target;
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        target = player.transform.position;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 0.009f);
        }
        
    /*    if (other.gameObject.CompareTag("Player"))
        {
            target = other.transform.position;
        }
    */    
    }
}
