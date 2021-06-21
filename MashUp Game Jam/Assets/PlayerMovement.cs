using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rb;

	public CharacterController2D controller;

	public float runSpeed = 40f;

	public Animator animator;

	public float lastJump;
	public HP hp;
	public PolygonCollider2D Attack;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	public bool unlockedDoubleJump = false;
	public bool hasdoubleJump = true;
	public bool doubleJump = false;
	public float interval;
	public float lastStep;
    public void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		hp = GetComponent<HP>();
		animator = GetComponent<Animator>();
		Attack = GetComponentInChildren<PolygonCollider2D>();
		Attack.enabled = false;
		FindObjectOfType<AudioManager>().Play("Music");
    }

    // Update is called once per frame
    void Update()
	{
		
		if (hp.playerIsDead == true)
		{
			animator.SetBool("Dead", true);
			if (Input.anyKey)
            {
				SceneManager.LoadScene(0);
            }
		}
		else
		{
			if (controller.m_Grounded == true)
            {
				hasdoubleJump = true; 
            }

			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			if (Mathf.Abs(horizontalMove) > 0.01f && controller.m_Grounded == true) 
            {
		
				if (lastStep < Time.time - interval)
                {
					FindObjectOfType<AudioManager>().Play("Pigstep");
					lastStep = Time.time;

                }
			}

			if (controller.m_Grounded == true)
			{
				if (Input.GetButtonDown("Jump"))
				{
					jump = true;
					animator.SetBool("Jump", true);
					if (controller.m_Grounded == true)
					{ FindObjectOfType<AudioManager>().Play("Jump"); }

					lastJump = Time.time;
				}
			} else if (unlockedDoubleJump == true && hasdoubleJump == true && Input.GetButtonDown ("Jump"))
            {
				doubleJump = true;
				animator.SetBool("Jump", true);
			     FindObjectOfType<AudioManager>().Play("Jump"); 

				hasdoubleJump = false;
			}
			 
		    
			if (Input.GetButton("Crouch"))
			{
				if (controller.m_Grounded == true)
				{
					crouch = true;
				}
				else
				{
					crouch = false;
				}
			}
			else if (Input.GetButtonUp("Crouch"))
			{
				if (controller.m_Grounded == true)
				{
					crouch = false;
				}
			}
			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
			if (controller.m_Grounded == true)
			{
				if (Time.time > lastJump + 0.2)
				{
					animator.SetBool("Jump", false);
				}
			}
			if (crouch == true)
			{
				animator.SetBool("Crouch", true);
			}
			else
			{
				animator.SetBool("Crouch", false);
			}
		}
	}

	void FixedUpdate()
	{
		
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
		if (doubleJump == true)
        {
			rb.AddForce(Vector2.up * 400f, ForceMode2D.Force);
			doubleJump = false;
        }

	}
	public void AttackEnd()
    {
		animator.SetBool("isAttacking", false);
		Attack.enabled = false;
	}
	public void DamageEnd()
    {
		animator.SetBool("Hurt", false);
    }
	public void DestroyPlayer()
    {

    }
	public void DieSound()
    {
		FindObjectOfType<AudioManager>().Play("Death");
    }
	public void Land()
    {
		FindObjectOfType<AudioManager>().Play("Land");
	}
}