using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour

{
    public float speed;
    public Vector2 playerPosition;
    public Vector2 position;
    public GameObject player;
    public Rigidbody2D rb;
    public Vector2 jump;
    public float jumpForce;
    public bool hasJump;
    public float playerHeight;
    public bool doJump;
    public HP hp;

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;

        rb = GetComponent<Rigidbody2D>();

        jump = new Vector2(0, jumpForce);
        hp = player.GetComponent<HP>();
    }

    public void FixedUpdate()
    {
        if (doJump == true)
        {
            rb.AddForce(jump);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {

        }
        else
        {
            if (player.transform.position.y > transform.position.y + playerHeight)
            {

                if (hasJump == true)
                {
                    doJump = true;
                }
                else
                {
                    doJump = false;
                }
            }
            else
            {
                doJump = false;
            }
            playerPosition = new Vector2(player.transform.position.x, transform.position.y);
        }
        
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerPosition, step);


    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            hasJump = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            hasJump = false;
        }
    }

    public void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == ("Player"))
        {
            if (hp.lastHit < Time.time - hp.iFrames)
            {
                hp.Health = hp.Health - hp.dmg;
                hp.lastHit = Time.time;
            }

        }
    }


}