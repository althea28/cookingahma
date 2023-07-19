using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ricebucket : MonoBehaviour
{
    public Transform rawRiceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (gameflow3.potAStep == 1) {
            Instantiate(rawRiceObj, gameflow3.potACoords + gameflow3.addRiceCoords, rawRiceObj.rotation);
            gameflow3.potAStep ++;
        } else if (gameflow3.potBStep == 1) {
            Instantiate(rawRiceObj, gameflow3.potBCoords + gameflow3.addRiceCoords, rawRiceObj.rotation);
            gameflow3.potBStep ++;
        }
        //reset
        gameflow3.resetClicks = true;

    }
}
