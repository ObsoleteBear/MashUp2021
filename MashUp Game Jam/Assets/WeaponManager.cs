using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public bool isHolding;
    // Start is called before the first frame update
    public string triggerTag;

    public int damage;
    public Vector2 Knockback;

    public PolygonCollider2D attackCollider;

    public List<float> itemDistance;
    public void LateUpdate()
    {
        itemDistance.Clear();
    }
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
    public void Awake()
    {
        attackCollider = GetComponentInChildren<PolygonCollider2D>();
        attackCollider.enabled = false;
        itemDistance = new List<float>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding == true && Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<AudioManager>().Play("weaponSwing");
            attackCollider.enabled = true;
        }
    }
}

