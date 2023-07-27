using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/*Part of pulut hitam dish. Supports mechanism to add milk to pulut hitam.
*/
public class milkbowl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /* Indicate in gameflow3 that  milk has been clicked. Supports mechanism to add milk to pulut hitam.
    */
    void OnMouseDown() {
        gameflow3.milkIsClicked = true;

        //reset
        gameflow3.bowlAClicked = false;
        gameflow3.bowlBClicked = false;
        gameflow3.resetClicksOndeh = true;
    }
}
