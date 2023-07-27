using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of rojak dish. Supports cutting ingredients mechanism
*/
public class knifeholder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Indicates in gameflow2 that knife is clicked. Supports cutting ingredients mechanism
    */
    void OnMouseDown() {
        gameflow2.knifeClicked = true;

        //RESET
        gameflow2.resetClicksChweeKueh = true;

        gameflow2.sauceClicked = false;
        gameflow2.boardAClicked = false;
        gameflow2.boardBClicked = false;
        gameflow2.bowlAClicked = false;
        gameflow2.bowlBClicked = false;

    }
}
