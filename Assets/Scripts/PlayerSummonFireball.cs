using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSummonFireball : MonoBehaviour
{
    private float timer;
    private float originalTimer;
    private GameObject target;
    public Vector3 offset;
    [SerializeField] private GameObject projectile;
    public KeyCode shootButton;
    
    // Start is called before the first frame update
    void Start()
    {
        originalTimer = 3;
        timer = originalTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<0)
        {
            
        }
        //when button is pressed
        if (Input.GetKey(shootButton)) 
        {
            //if fireball exists don't make another one
            if (GameObject.FindGameObjectWithTag("PlayerFireball") != null)
            {
                Destroy(GameObject.FindGameObjectWithTag("PlayerFireball"));
            }
            else
            {
                Instantiate(projectile, transform.position + offset, Quaternion.identity);
            }
        }
    }
}
