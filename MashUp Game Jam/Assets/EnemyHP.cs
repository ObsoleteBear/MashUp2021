using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP = 5;
    public bool enemyIsDead = false;
    public float lastHit;
    public float iFrames;
    public Rigidbody2D rb;

    public GameObject Player;

    public WeaponManager weapon;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        weapon = Player.GetComponent<WeaponManager>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            if (enemyHP < 1)
        {
            enemyIsDead = true;

        }
        if (enemyIsDead == true)
        {
           Destroy(gameObject);
        }
    }

    public void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == ("Attack"))
        {
            if (lastHit < Time.time - iFrames)
            {
                enemyHP = enemyHP - weapon.damage;
                lastHit = Time.time;
                animator.SetBool("Hurt", true);
                if (transform.position.x < Player.transform.position.x)
                {
                    rb.AddForce(new Vector2(-weapon.Knockback.x, weapon.Knockback.y), ForceMode2D.Impulse);
                }
                else
                {
                    rb.AddForce(weapon.Knockback, ForceMode2D.Impulse);
                }
            }

        }
    }
}
