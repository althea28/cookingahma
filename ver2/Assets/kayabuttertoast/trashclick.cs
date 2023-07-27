using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/*Support trashing mechanism for kaya butter toast and soft boiled egg dish
*/
public class trashclick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Triggers destroying of dish objects that the player is trying to trash. 
    */
    void OnMouseDown() {
        if (gameflow.toastAIsClicked) {
            gameflow.trashA = true;
            gameflow.toastAIsClicked = false;
        } else if (gameflow.toastBIsClicked) {
            gameflow.trashB = true;
            gameflow.toastBIsClicked = false;
        } else if (gameflow.plateAClicked) {
            gameflow.trashPlateA = true;
            gameflow.plateAClicked = false;
        } else if (gameflow.plateBClicked) {
            gameflow.trashPlateB = true;
            gameflow.plateBClicked = false;
        }

        //RESET===
        gameflow.placeKaya = false; 
        gameflow.placeButter = false;
        gameflow.soyaSauceClicked = false;


    }
}
