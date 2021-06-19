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








//                           +NMMMMMMMMMN +
//                        `/ NMMMMMMMMMMMMMN +`                                     
//                      `/ d + ohMMMMMMMMMMMMMMm +`                                   
//                      :MMMM`:hNMMMMMMMMMMMMM:
//                      :MMMM osmMMdoo/+oooNM/                                   
//                      :MMMM dNMMMMNh `NNNMM/                                   
//                      :MMMs dMMMMMm+ `sMyNM/                                   
//                     .oyymmmMd:yMMNmmmmy / +y -
//                      -y:sMMMM:.- sMMMMMM N /`                                    
//                      -y`MMMMdmdmMMMMN: N.
//                        ` +mmmmmmmmmmdo  N.
//                           ss - +s:/ s + -yd  N.    ```````                          
//                :++---sN - hN + oNy - Ns  N. `-/ +ymdd + o```                       
//              hNMMNo.      .`.-``-.`.   N./ o//yds:o:dddd+:.                    
//               yNMMMs -`.`..`.`- -hd. .sds.`:ooooo: yddo.        .--.
//           dMMMmo.    .+`s: ++/ s.oyMm`.smm +`/ hMMMMMMh /`-ymys.- yyyo///+/.    
//       `.-ss +   / mMMMMm +.ddoo + oo + oodm +`.dMy -/ hNMMMMMMMMN +`-yMMNdm++.   `+s
//     `:ymNMN. +. / dNMMMMm +`-..........-`+mMy.:hMMMMMMMMMMMN + -sso..-:`    
//     oNMMMNs `Nm + ..+dMMMMMmm +/.``-///+mmMNh+.sMMMMMMMMMMMMM+                    
//    oNMMMMd  dMMMm + ..+dMMMMMMMmddmMMMMNddohN / +mMMMMMMMMMMMM +
//    yMMMMMd  MMMMMMm +`:MN / MMMMMMMMNmhoohhMMM +`+NMMMMMMMMMMs.
//        sNMMMMd / MMMMMMMy - oNy / modNNy + syhMMMMMMMMo`.sNMMMMMNNo.
//               sMMMMNo + NMMMMMMmosm`oNyssshdooosMMMMMMMh: .osssss.
//     `/ dNMMN + oNMMMMMMMmoo.NMMNNMNh + omMMMMMMMo` `odooos.
//     :yy//yyy   omMMMMMMMMmmMMMMMMdosNsMMMMMd/`  .osmmo`                        
//    .sy///       .-omMMMMMMMMMMMMMdoyMMMMdd/`    :MMMM`                         
//  .sNMNo./ ommmmmmmmmmmmmmd///        :MMMm`                         
// `mMMM +                    ``````                :MMM
//  + Nyoooooooooooooooooo / MMMMMMd:              :MMM                           
// `+ssdMMMMMMMMyssss / -++/  ````+s /               :MMM                           
//      `........+NMMMd  :do.                 - hMM
//               .-- / dh  mMMm / -N -
//         `.  ...   `./ ys.mMMM + -hh
//         :mo.mmmyssdNMMMh ` dNNN /                :d``                           
//         .yNmss.+ smMMMm +.oNo.````                :d`N                           
//           `.yMNNNNMMy``+yyymNNNs//////          :d.M                           
//              ..shhh +``/ hmmmoooyhhhdMMN          :d.M.-
//                     :dd.dMMMMMmdddyoo -          :m: h-- - oms
//                       / MNs`/ dmMMMMNmho + -h:-yy`  `.....-yyyymNNMNo
//                / MMm  ``/ +++::hNd`          `:sNmo``+dNNNNNNMMMMMMNy:`     
//                     / MNo - hMMd - mNM.`/ dNMMMMMMMMNNNys:`       
//                    .sMd: MMN /         `.-y dMMMMMMMNyyy...           
//                    +MMd           `+MMM:             hhNMMMMMNy:::             
//                   / mMd - ---        `+MMM:              -:yddddddd:
//                `+mMm. ::`            ```````              
//             +.`````:o/  ```sN:        `o. `+do`                                
//             .dmmms+////+mmmMy.    .:    `/hNMNo`                               
//              -mMMmho-/osMMMM-   .oy- `::dNd/omNo                               
//               -yNmhhysdddMMM-   .odhhdMMd/`.odmNo                              
//                 yNh+/..-yMMM-     .oNMMMhysds-oMd`                             
//                  sNMMMNNNMMM:       `+NMMMy-/dMMMh                             
//                  `:hm+...sMMN:        `oNMMNMMMd+-ooooooooo:`                  
//            ``//////yNmmmmmMMMs.         .mMMMMy-oNMMMMMMMMMNh:                 
//          `/ddMMMMMMMMMMMMMMMMM/          mMMMMNmMMMMMMMMMMMMMd-                
//         -dMMMMMMMMMMMMMMMMMMMM/          yNMMMMMMMMMMMMMMMMMMMd                
//         -NMMMMMMMMMMMMMMNN////.           hNNNNNNMMMMMMMMMMMMMh                
//          `+++++++++++++/                        .++++++++++++:






















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