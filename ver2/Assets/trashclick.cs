using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashclick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (gameflow.toastAIsClicked == "y") {
            gameflow.trashA = "y";
            gameflow.toastAIsClicked = "n";
        } else if (gameflow.toastBIsClicked == "y") {
            gameflow.trashB = "y";
            gameflow.toastBIsClicked = "n";
        }

    }
}
