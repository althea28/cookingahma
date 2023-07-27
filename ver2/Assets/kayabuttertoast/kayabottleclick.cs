using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* class kayabottleclick attached to kaya bottle, interacted with when player wants to add kaya to toast.
*/

public class kayabottleclick : MonoBehaviour
{
    
    public Transform kayaObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Indicate in gameflow when kaya bottle is clicked.
     * Resets other sticky clicks in kaya butter toast and soft boiled eggs dishes.
    */
    void OnMouseDown() {
        gameflow.placeKaya = true;
        
        //RESET====
        gameflow.resetClicksEggs = true;
        gameflow.toastAIsClicked = false;
        gameflow.toastBIsClicked = false;
        gameflow.placeButter = false;
    }
}
