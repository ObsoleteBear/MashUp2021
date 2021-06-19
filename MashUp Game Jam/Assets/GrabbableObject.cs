using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{

    public bool Grabbed = false;
    public string colliderTag;
    // Start is called before the first frame update
    void Start()
    {
        
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
                    Grabbed = true;
                }
            }
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