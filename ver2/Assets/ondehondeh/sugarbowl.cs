using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarbowl : MonoBehaviour
{
    public static bool sugarOnDough = false; 
    public Transform sugarCubeObj;

    // Start is called before the first frame update
    void Start()
    {
        sugarOnDough = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (!sugarOnDough) {
            Instantiate(sugarCubeObj, gameflow3.sugarOnDoughCoords, sugarCubeObj.rotation);
            sugarOnDough = true;
        }

        //reset
        gameflow3.resetClicks = true;
    }
}
