using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnMouseDown() {
        gameflow.placeKaya = "y";
        
        //RESET====
        gameflow.resetClicksEggs = true;
        gameflow.toastAIsClicked = "n";
        gameflow.toastBIsClicked = "n";
        gameflow.placeButter = "n";
    }
}
