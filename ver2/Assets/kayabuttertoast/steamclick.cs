using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* class steamclick destroys steam on toast when toast is cooking. Called when moving kaya butter toast from grill to breadboard.
*/

public class steamclick : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   /* Destroys steam when needed.
   */
    void Update()
    {
        if ((gameflow.destroySteamA) && (transform.position == gameflow.grillACoordinates)) {
           Destroy (gameObject);
           gameflow.destroySteamA = false;
       } else if ((gameflow.destroySteamB) && (transform.position == gameflow.grillBCoordinates)) {
           Destroy (gameObject);
           gameflow.destroySteamB = false;
       }

    }
}
