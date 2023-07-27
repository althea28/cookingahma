using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of ondeh ondeh dish. Adds gula melaka cube to dough.
*/
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
    
    /*Adds Adds gula melaka cube to dough if there is space
    */
    void OnMouseDown() {
        if (!sugarOnDough) {
            Instantiate(sugarCubeObj, gameflow3.sugarOnDoughCoords, sugarCubeObj.rotation);
            sugarOnDough = true;
        }

        //reset
        gameflow3.resetClicks = true;
    }
}
