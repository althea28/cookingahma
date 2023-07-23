using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class sugarplate : MonoBehaviour
{
    public Transform sugarObj;
    public Transform steamObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (gameflow3.potAStep == 3) {
            Instantiate(sugarObj, gameflow3.potACoords + gameflow3.addSugarCoords, sugarObj.rotation);
            gameflow3.potAStep ++;

            pot.isCookingA = true;
            Instantiate(steamObj, gameflow3.potACoords, steamObj.rotation);

        } else if (gameflow3.potBStep == 3) {
            Instantiate(sugarObj, gameflow3.potBCoords + gameflow3.addSugarCoords, sugarObj.rotation);
            gameflow3.potBStep ++;

            pot.isCookingB = true;
            Instantiate(steamObj, gameflow3.potBCoords, steamObj.rotation);

        }
        //reset
        gameflow3.resetClicks = true;
    }
}
