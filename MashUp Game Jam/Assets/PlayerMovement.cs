using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame
 
    public CharacterController Player;
    public float playerSpeed;
    public Vector2 playerVelocity;
    public float gravityScale;
    public bool grounded; 
   void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        Player.Move(move * Time.deltaTime * playerSpeed);
        playerVelocity.y += gravityScale * Time.deltaTime;
        Player.Move(playerVelocity * Time.deltaTime);
        grounded = Player.isGrounded;
        if (grounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }


    }  
}
    