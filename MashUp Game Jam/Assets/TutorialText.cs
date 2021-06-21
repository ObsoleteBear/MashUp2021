using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour
{
    public GrabbableObject sign;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sign = FindObjectOfType<GrabbableObject>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if (sign.touchingPlayer == true)
        {
            animator.SetBool("fadeIn", true);
        }else
        {
            animator.SetBool("fadeIn", false);
        }

    }


    
}
