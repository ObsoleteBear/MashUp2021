using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   

    public class HP : MonoBehaviour
{
    public float lastHit;
    public float iFrames = 10;
    public bool playerIsDead = false;
    public Rigidbody2D rb;
    public int dmg;
    public PlayerMovement playerMovement;


    public int Health = 100; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health < 1)
        {
            playerIsDead = true;
           
        }
        if (playerIsDead==true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
