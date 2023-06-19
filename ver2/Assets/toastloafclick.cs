using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastloafclick : MonoBehaviour
{
    public Transform toastObj;
    //public Transform steamObj;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(steamObj, steamObj.position, steamObj.rotation);

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
    }
}
