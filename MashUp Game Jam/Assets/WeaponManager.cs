using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public bool isHolding;
    // Start is called before the first frame update
    public string [ ]triggerTag;
   



    public void OnTriggerStay2D(Collider2D trigger)
    {

        triggerTag = new string[10];
        

    }
    void Start()
    {
        
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
                //(trigger.gameObject.tag == "Grabbables")
            }
        }

    }
}

