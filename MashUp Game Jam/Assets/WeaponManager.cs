using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public bool isHolding;
    // Start is called before the first frame update
    public string triggerTag;

    public Animator attackAnimator;

    public PolygonCollider2D attackCollider;


    public void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.tag == ("Grabbables"))
        {
            triggerTag = trigger.tag;
        }
    }
    public void OnTriggerExit2D(Collider2D trigger)
    {
        if (trigger.tag == ("Grabbables"))
        {
            triggerTag = null;
        }
    }
    void Start()
    {
        attackCollider = GetComponentInChildren<PolygonCollider2D>();
        attackCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            if (isHolding == true)
            {
                isHolding = false;
            }
            else
            {
                if (triggerTag == "Grabbables")
                {
                    isHolding = true;
                }
            }
        }

        if (isHolding == true && Input.GetMouseButtonDown(0))
        {
            attackCollider.enabled = true;
            attackAnimator.SetBool("IsAttacking", true);
        }
        if (isHolding == true && Input.GetMouseButtonUp(0))
        {
            attackCollider.enabled = false;
            attackAnimator.SetBool("IsAttacking", false);
        }
    }
}

