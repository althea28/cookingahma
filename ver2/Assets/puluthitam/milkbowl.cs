using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnMouseDown() {
        gameflow3.milkIsClicked = true;

        //reset
        gameflow3.bowlAClicked = false;
        gameflow3.bowlBClicked = false;
        gameflow3.resetClicksOndeh = true;
    }
}
