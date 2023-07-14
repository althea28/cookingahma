using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehdough : MonoBehaviour
{
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
        if ((sugarbowl.sugarOnDough) && (!gameflow3.doughOnSteamerA)) {
            sugarcube.destroy = true;
            sugarbowl.sugarOnDough = false;
            
            gameflow3.doughOnSteamerA = true;
            ondehsteamer.startCookingA = true;
            Instantiate(steamObj, gameflow3.steamerACoords, 
                steamObj.rotation);
        } else if ((sugarbowl.sugarOnDough) && (!gameflow3.doughOnSteamerB)) {
            sugarcube.destroy = true;
            sugarbowl.sugarOnDough = false;
            
            gameflow3.doughOnSteamerB = true;
            ondehsteamer.startCookingB = true;
            Instantiate(steamObj, gameflow3.steamerBCoords, 
                steamObj.rotation);
        } 

        //reset
        gameflow3.resetClicksOndeh = true;
    }
}
