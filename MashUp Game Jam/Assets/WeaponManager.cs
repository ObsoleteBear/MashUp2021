using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public bool isHolding;
    // Start is called before the first frame update
    public string triggerTag;

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

        if (Input.GetKey("e"))
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

        if (isHolding == true && Input.GetMouseButton(0))
        {
            attackCollider.enabled = true;
            //NOTE TO PAUL: MAKE THIS ACTIVATE THE ATTACK ANIMATION
        }
    }
}

