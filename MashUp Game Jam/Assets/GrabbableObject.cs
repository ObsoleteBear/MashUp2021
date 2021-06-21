using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{

    public bool Grabbed = false;
    public string colliderTag;
    public GameObject Player;
    public WeaponManager weaponManager;
    public float distanceToPlayer;
    public float rotateSpeed;
    public Animator animator;
    public Animator playerAnimator;
    public bool touchingPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        weaponManager = Player.GetComponent<WeaponManager>();
        animator = gameObject.GetComponent<Animator>();
        playerAnimator = Player.GetComponent<Animator>();
    }

    public void OnTriggerStay2D(Collider2D Collider)
    {
        if (Collider.tag == "Player")
        {
            colliderTag = Collider.tag; 
        }
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            colliderTag = null;
        }            
    }

    public void LateUpdate()
    {
        weaponManager.itemDistance.Clear();
    }
    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {

        } else
        {
            if (colliderTag == "Player")
            {
                touchingPlayer = true;
            } else
            {
                touchingPlayer = false;
            }

            distanceToPlayer = Vector2.Distance(Player.transform.position, transform.position);
        }
        weaponManager.itemDistance.Add(distanceToPlayer);
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Epress");
            if (Grabbed == false)
            {
                if (weaponManager.isHolding == false)
                {
                    Debug.Log(weaponManager.isHolding);

                    if (colliderTag == "Player")
                    {
                        if (distanceToPlayer >= weaponManager.itemDistance.Min())
                        {
                            Debug.Log("Grabbed an  object");
                            Grabbed = true;
                            FindObjectOfType<AudioManager>().Play("PickUpWeapon");
                            weaponManager.isHolding = true;
                        }
                    }
                }
            } else 
            {
                weaponManager.isHolding = false;
                Grabbed = false;
                Debug.Log(weaponManager.isHolding);
                Debug.Log(Grabbed);
            }
        }
    if (Grabbed == true)
        {
            gameObject.transform.parent = Player.transform;
            gameObject.transform.localPosition = new Vector2(0.327f, 0.515f);
            gameObject.transform.localScale = new Vector2 (0.6f, 0.6f);
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetBool("Attack", true);
            }
        }
    else
        {
            gameObject.transform.parent = null;
            gameObject.transform.localScale = new Vector2(1f, 1f);
        }        
                
    }

public void OnAttackEnd()
    {
        animator.SetBool("Attack", false);
    }    
    public void AttackStarted()
    {
        playerAnimator.SetBool("isAttacking", true);
    }
}

//   `oooooooo /            / oooooooo`                        
//                   :sss``+++hMMMMNsssss`  -sssNMMMMMMy +``sss:
//                 .hmMMMhhho.::::::::::   `::::::::::` yhMMMmh.
//               mmMMMMMMN..mMMMMMMmm
//                `:NNN /```  `````NNNNNNNNNNNNNNNN`````  ```/ NNN:`                
//         .......         .+MMMMMMMMMMMMMMMMMMMMMMMMMM +.         .......         
//       :/ MMMMMMM:-     :/ MMMMMMMMNhhhNMMMMNhhhNMMMMMMMM /:     -:MMMMMMM /:       
//     :+NMMMMMMMMMd   :+NMMMMMMMMMd   yMMMMy dMMMMMMMMMN+:   dMMMMMMMMMN +:     
//   -omMMNoooooooo / yMMMMMMMMMMMd   yMMMMy dMMMMMMMMMMMy   /ooooooooNMMmo-   
//   +MMMMNyyyyyyy     yMMMMMMMMMMMd   yMMMMy   dMMMMMMMMMMMy     yyyyyyyNMMMM+   
//   +MMMMMMMMMMMMds   yMMMMMMMMMMMd   yMMMMy   dMMMMMMMMMMMy   sdMMMMMMMMMMMM+   
//   `...NMMMMMMMMMd   yMMMMMMo.dMMMmmmNMMMMNmmmMMMd.oMMMMMMy   dMMMMMMMMMN...`   
//        `mNMMMMMMd.`   mMMMMMM-   ............   -MMMMMMm   `.dMMMMMMNm`        
//         :dddddddd + ydMMMMM + - .dddddddddddd. - +MMMMMdy + dddddddd:          
//                   ./.  `ydMMMMM /:            :/ MMMMMdy`  ./.
//                  ooohM /    .odMMMMmoooooooooooomMMMMdo.    / Mhooo
//                + sMMMMM / -+++MMMMMMMMMMMMMMMM++ + -      / MMMMMs +
//  
//              / hNMMMMh:shhy::::::::::::::::       yhhs:hMMMMNh /
//        sMMMMd.+ mNMMMmmmmm - -mmmmmMMMNm +.dMMMMs
//            sMMMMd`oMMMMMMMMMMNNNNmmmmm``mmmmmNNNNMMMMMMMMMMo`dMMMMs
//            + mmmMMMMMMMMMMNmmmmmmy            ymmmmmmNMMMMMMMMMMmmm +
//                 hhhhhhhhhho                          ohhhhhhhhhh
//                                   - +++`                                        
//                                 .ohMMMso
//                                 - MMMMMMm
//                                ddMMMMM: -
//                                 MMMMM +.
//                                 mNMMM +.
// 
//                                  - MMMMM / -
// 
//                                  .ydMMMMN / -
//                                    -omMMMMy
//                                     :+NMMms:                                   
//                                       mMMMM +
//                                     smMMMMMNm -
//                            oN -   `+NMMMMMMMMM - -No
//                             + m /. - mNMMMMMMMMNm - ./ m +
//                               sh:- :hhhhhhhh: -:hs
//                                 ss++++++++++++ss                                
//                                 `oooooooooooo`