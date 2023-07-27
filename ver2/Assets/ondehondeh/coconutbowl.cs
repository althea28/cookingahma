using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Part of ondeh ondeh dish. Supports adding coconut to ondeh ondeh.
*/
public class coconutbowl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*Indicate in gameflow3 that coconut flakes bowl has been clicked. Supports mechanism of adding coconut to ondeh ondeh.
    */
    void OnMouseDown() {
        gameflow3.coconutClicked = true;
        
        //reset
        gameflow3.ondehPlateAClicked = false;
        gameflow3.ondehPlateBClicked = false;
        gameflow3.resetClicksPulut = true;

    }
}
