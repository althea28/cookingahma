using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of chwee kueh dish. Instantiates chwee kueh batter and tins on steamer.
*/
public class batterbucket : MonoBehaviour
{
    public Transform ckTinsObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /* Instantiates new chwee kueh batter and tins on steamer, if there is space on steamer.
    */
    //to instantiate eggs onto steamer
    void OnMouseDown() {
        if (!gameflow2.ckOnSteamerA) { //if there is no eggs on steamer A
            Instantiate(ckTinsObj, gameflow2.steamerACoords, ckTinsObj.rotation);
            gameflow2.ckOnSteamerA = true; //indicate in gameflow that there is an egg on steamer A

        } else if (!gameflow2.ckOnSteamerB) { //if there is no eggs on steamer B
            Instantiate(ckTinsObj, gameflow2.steamerBCoords, ckTinsObj.rotation);
            gameflow2.ckOnSteamerB = true; //indicate in gameflow that there is an egg on steamer B
        }

        gameflow2.resetClicks = true;
    }
}
