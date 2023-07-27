using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of chwee kueh dish. Destroys steam when mvoving chwee kueh from steamer to plate.
*/
public class steamclick2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys steam when moving chwee kueh from steamer to plate.
    */
    void Update()
    {
        if ((gameflow2.destroySteamA) && (transform.position == gameflow2.steamerACoords)) {
           Destroy (gameObject);
           gameflow2.destroySteamA = false;
       } else if ((gameflow2.destroySteamB) && (transform.position == gameflow2.steamerBCoords)) {
           Destroy (gameObject);
           gameflow2.destroySteamB = false;
       }

    }
}
