using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of pulut hitam dish. Instantiates rice in pot.
*/
public class ricebucket : MonoBehaviour
{
    public Transform rawRiceObj;
    private int stepToAddRice = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* Instantiates rice in pot when pot is empty.
    */
    void OnMouseDown() {
        if (gameflow3.potAStep == stepToAddRice) {
            Instantiate(rawRiceObj, gameflow3.potACoords + gameflow3.addRiceCoords, rawRiceObj.rotation);
            gameflow3.potAStep ++;
        } else if (gameflow3.potBStep == stepToAddRice) {
            Instantiate(rawRiceObj, gameflow3.potBCoords + gameflow3.addRiceCoords, rawRiceObj.rotation);
            gameflow3.potBStep ++;
        }
        //reset
        gameflow3.resetClicks = true;

    }
}
