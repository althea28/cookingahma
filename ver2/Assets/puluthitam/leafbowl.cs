using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of pulut hitam dish. Adds pandan leaf to pot.
*/
public class leafbowl : MonoBehaviour
{
    public Transform pandanObj;
    private int stepToAddLeaves = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Adds pandan leaf to pot if rice has already been added
    */
    void OnMouseDown() {
        if (gameflow3.potAStep == stepToAddLeaves) {
            Instantiate(pandanObj, gameflow3.potACoords + gameflow3.addPandanCoords, pandanObj.rotation);
            gameflow3.potAStep ++;
        } else if (gameflow3.potBStep == stepToAddLeaves) {
            Instantiate(pandanObj, gameflow3.potBCoords + gameflow3.addPandanCoords, pandanObj.rotation);
            gameflow3.potBStep ++;
        }

        //reset
        gameflow3.resetClicks = true;
    }
}
