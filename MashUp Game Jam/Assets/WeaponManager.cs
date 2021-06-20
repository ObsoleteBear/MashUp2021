using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public bool isHolding;
    // Start is called before the first frame update
    public string triggerTag;

    public PolygonCollider2D attackCollider;

    public List<float> itemDistance = new List<float>();

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
        if (isHolding == true && Input.GetMouseButton(0))
        {
            attackCollider.enabled = true;

        }
    }
}

