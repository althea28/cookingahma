using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of rojak dish. Supports adding sauce to bowl.
*/
public class rojakSauce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /* Indicate in gameflow2 that sauce has been clicked. Supports adding sauce to bowl.
    */
    void OnMouseDown() {
        gameflow2.sauceClicked = true;    

        //RESET
        gameflow2.resetClicksChweeKueh = true; 
        
        gameflow2.knifeClicked = false;
        gameflow2.boardAClicked = false;
        gameflow2.boardBClicked = false;
        gameflow2.bowlAClicked = false;
        gameflow2.bowlBClicked = false;

        }
}
