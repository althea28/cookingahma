using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnMouseDown() {
        gameflow3.coconutClicked = true;
        
        //reset
        gameflow3.ondehPlateAClicked = false;
        gameflow3.ondehPlateBClicked = false;
        gameflow3.resetClicksPulut = true;

    }
}
