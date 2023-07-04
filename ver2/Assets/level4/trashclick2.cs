using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashclick2 : MonoBehaviour
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
        if (gameflow2.plateAClicked) {
            gameflow2.trashPlateA = true;
            gameflow2.plateAClicked = false;
        } else if (gameflow2.plateBClicked) {
            gameflow2.trashPlateB = true;
            gameflow2.plateBClicked = false;
        }

        //RESET===
        gameflow2.chaiPohClicked = false;
    }

}
