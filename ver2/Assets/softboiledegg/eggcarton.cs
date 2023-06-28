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

    //to instantiate eggs onto steamer
    void OnMouseDown() {
        if (!gameflow.eggOnSteamerA) { //if there is no eggs on steamer A
            Instantiate(eggsObj, gameflow.steamerACoords, eggsObj.rotation);
            gameflow.eggOnSteamerA = true; //indicate in gameflow that there is an egg on steamer A

        } else if (!gameflow.eggOnSteamerB) { //if there is no eggs on steamer B
            Instantiate(eggsObj, gameflow.steamerBCoords, eggsObj.rotation);
            gameflow.eggOnSteamerB = true; //indicate in gameflow that there is an egg on steamer B
        }

        gameflow.resetClicks = true;
    }
}
