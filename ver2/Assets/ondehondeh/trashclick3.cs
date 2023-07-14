using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashclick3 : MonoBehaviour
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
        if (gameflow3.ondehPlateAClicked) {
            gameflow3.destroyOndehA = true;
        } else if (gameflow3.ondehPlateBClicked) {
            gameflow3.destroyOndehB = true;
        }
        //reset
        gameflow3.resetClicksOndeh = true;
    }
}
