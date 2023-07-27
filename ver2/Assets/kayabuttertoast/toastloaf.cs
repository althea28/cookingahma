using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Instantiates new toast on grill if possible.
*/
public class toastloaf : MonoBehaviour
{
    public Transform toastObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Checks if there is space on the grill where new toast can be instantiated
    */
    void OnMouseDown() {
        if (!gameflow.toastOnGrillA) {
            Instantiate(toastObj, gameflow.grillACoordinates, toastObj.rotation);
            gameflow.toastOnGrillA = true;
        } else if (!gameflow.toastOnGrillB) {
            Instantiate(toastObj, gameflow.grillBCoordinates, toastObj.rotation);
            gameflow.toastOnGrillB = true;
        }

        //RESET===
        gameflow.resetClicks = true;
    }
}
