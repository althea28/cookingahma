using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of chwee kueh dish. Supports adding chai poh to chwee kueh.
*/
public class chaipohbowl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Indicates in gameflow2 when chaipoh bowl is clicked.
    */
    void OnMouseDown() {
        gameflow2.chaiPohClicked = true;

        //RESET===
        gameflow2.resetClicksRojak = true;
        gameflow2.plateAClicked = false;
        gameflow2.plateBClicked = false;
    }
}
