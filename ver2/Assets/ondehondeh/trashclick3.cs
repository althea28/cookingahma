using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Supports trashing mechanism for levels 7 to 9.
*/
public class trashclick3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*Trigger destroying of dish that player is trying to trash
    */
    void OnMouseDown() {
        if (gameflow3.ondehPlateAClicked) {
            gameflow3.destroyOndehA = true;
        } else if (gameflow3.ondehPlateBClicked) {
            gameflow3.destroyOndehB = true;
        } else if (gameflow3.bowlAClicked) {
            gameflow3.destroyPulutA = true;
        } else if (gameflow3.bowlBClicked) {
            gameflow3.destroyPulutB = true;
        }

        //reset
        gameflow3.resetClicks = true;
    }
}
