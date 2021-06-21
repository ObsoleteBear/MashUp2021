using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PickupScript : MonoBehaviour
  

{
    public PlayerMovement PlayerMovement;
   


    public void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Player")
        {
            PlayerMovement.unlockedDoubleJump = true;
            FindObjectOfType <AudioManager>().Play("PowerUp");
            Destroy (gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
