using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Part of softboiled egg dish. Instantiates new egg on steamer if possible.
*/
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
    /* Instantiates new egg on steamer if there is space on steamer.
    */
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
