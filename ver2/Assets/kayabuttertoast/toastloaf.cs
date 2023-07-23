using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

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

    void OnMouseDown() {
        if (gameflow.toastOnGrillA == "n") {
            Instantiate(toastObj, gameflow.grillACoordinates, toastObj.rotation);
            gameflow.toastOnGrillA = "y";
        } else if (gameflow.toastOnGrillB == "n") {
            Instantiate(toastObj, gameflow.grillBCoordinates, toastObj.rotation);
            gameflow.toastOnGrillB = "y";
        }

        //RESET===
        gameflow.resetClicks = true;
    }
}
