using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnMouseDown() {
        gameflow.placeButter = "y";
        gameflow.toastAIsClicked = "n";
        gameflow.toastBIsClicked = "n";
    }
}
