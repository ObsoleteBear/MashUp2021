using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2D controller;

	public float runSpeed = 40f;

	public Animator animator;

	public float lastJump;
	public HP hp;
	public PolygonCollider2D Attack;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
    private void Start()
    {
		hp = GetComponent<HP>();
		animator = GetComponent<Animator>();
		Attack = GetComponentInChildren<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
	{
		if (hp.playerIsDead == true)
		{
			animator.SetBool("Dead", true);
		}
		else
		{
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

			if (Input.GetButtonDown("Jump"))
			{
				jump = true;
				animator.SetBool("Jump", true);
				lastJump = Time.time;
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
}