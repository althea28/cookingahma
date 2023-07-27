using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* class butterclick attached to block of butter, used when the player wants to add butter to toast for kaya butter toast object.
*/

public class butterclick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Indicate in gameflow when block of butter is clicked.
     * Resets other sticky clicks in kaya butter toast and soft boiled eggs dishes.
    */
    void OnMouseDown() {
        gameflow.placeButter = true;

        //RESET===
        gameflow.resetClicksEggs = true;
        gameflow.toastAIsClicked = false;
        gameflow.toastBIsClicked = false;
        gameflow.placeKaya = false;
    }
}
