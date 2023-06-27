using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggcarton : MonoBehaviour
{
    public Transform eggsObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (!gameflow.eggOnSteamerA) {
            Instantiate(eggsObj, gameflow.steamerACoords, eggsObj.rotation);
            gameflow.eggOnSteamerA = true;
        } else if (!gameflow.eggOnSteamerB) {
            Instantiate(eggsObj, gameflow.steamerBCoords, eggsObj.rotation);
            gameflow.eggOnSteamerB = true;
        }

        gameflow.resetClicks = true;
    }
}
