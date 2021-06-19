using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{

    public bool Grabbed = false;
    public string colliderTag;
    public GameObject Player;
    public WeaponManager weaponManager;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        weaponManager = Player.GetComponent<WeaponManager>();
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


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (Grabbed == true)
            {
                 Grabbed = false;
            }
            else
            {
                if (colliderTag == "Player")
                {
                    if (weaponManager.isHolding == false)
                    {
                        Grabbed = true;
                        
                    }
                }
            }
        }
    if (Grabbed == true)
        {
            gameObject.transform.SetParent(Player.transform);
            gameObject.transform.localPosition = new Vector2(0.327f, 0.515f);
            gameObject.transform.localScale = new Vector2 (0.6f, 0.6f);
        }
    else
        {
            gameObject.transform.SetParent(null);
            gameObject.transform.localScale = new Vector2(1f, 1f);
        }        
                
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