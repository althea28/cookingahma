using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of chwee kueh dish. Supports: 
 * (i) Adding chai poh
 * (ii) Trashing and serving mechanism
 */
public class rawChweeKueh : MonoBehaviour
{
    public Transform undercookedChaiPohObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys object when trashing or serving this dish.
    */
    void Update()
    {
        
        //trying to trash OR serve => destroy obj
        if (((gameflow2.trashPlateA) && (isOnPlateA())) || (((gameflow2.serveCkA) && (isOnPlateA()))))  {
            
            checkChaiPohA();
            /*if (gameflow2.hasCPOnA) { //if added chai poh to A, destroy it too.
                undercookedChaiPoh.trashChaiPohA = true;
            }*/

            gameflow2.trashPlateA = false;
            gameflow2.serveCkA = false;

            resetA();
            Destroy (gameObject);

        } else if (((gameflow2.trashPlateB) && (isOnPlateB())) || (((gameflow2.serveCkB) && (isOnPlateB())))) {

            checkChaiPohB();
            /*if (gameflow2.hasCPOnB) { //if added chai poh to B, destroy it too
                undercookedChaiPoh.trashChaiPohB = true;
            }*/

            gameflow2.trashPlateB = false;
            gameflow2.serveCkB = false;

            resetB();
            Destroy (gameObject);
        }
            
    }
    
    /* Supports: 
     * (i) Adding chaipoh
     * (ii) Trahsing and serving mechanism
    */
    void OnMouseDown() {

        if (gameflow2.chaiPohClicked) {

            //add chai poh to chwee kueh
            Instantiate(undercookedChaiPohObj, transform.position + gameflow2.addUndercookedCP, undercookedChaiPohObj.rotation);
            addedUndercookedChaiPoh(); //indicate in gameflow2 that added chai poh
            gameflow2.chaiPohClicked = false;
            
            //RESET===
            gameflow2.resetClicks = true;

        } else if (isOnPlateA()) {
            gameflow2.plateAClicked = true;
            //RESET===
            gameflow2.plateBClicked = false;

        } else if (isOnPlateB()) {
            gameflow2.plateBClicked = true;

            //RESET===
       
            gameflow2.plateAClicked = false;

        }
        //reset
        gameflow2.resetClicksRojak = true;
    }
    
    
    /*Check if chai poh has been added to plate A. If it has, destroy it
    */
    void checkChaiPohA() {
        if (gameflow2.hasCPOnA) { //if added chai poh to A, destroy it too.
                undercookedChaiPoh.trashChaiPohA = true;
            }
    }
    
    /*Check if chai poh has been added to plate B. If it has, destroy it
    */
    void checkChaiPohB() {
            if (gameflow2.hasCPOnB) { //if added chai poh to B, destroy it too
                undercookedChaiPoh.trashChaiPohB = true;
            }
    }

    /* Reset variables of plate A so new chwee kueh can be moved here.
    */
    void resetA() { //to reset added chai poh, is on plate A
        gameflow2.hasCPOnA = false;
        gameflow2.ckOnPlateA = false;
        gameflow2.plateACooked = false;
    }

    /* Reset variables of plate B so new chwee kueh can be moved here.
    */
    void resetB() { //to reset added chai poh, is on plate A
        gameflow2.hasCPOnB = false;
        gameflow2.ckOnPlateB = false;
        gameflow2.plateBCooked = false;

    }

    /* Indicate in gameflow2 that chai poh has already been added. Used again:
     * (i) to prevent repeated adding of chai poh later on
     * (ii) to check if chai poh needs to be destroyed when trashign/serving this dish
     */
    void addedUndercookedChaiPoh() {
        if (isOnPlateA()) {
            gameflow2.hasCPOnA = true;
        } else if (isOnPlateB()) {
            gameflow2.hasCPOnB = true;
        }
    }
    
    bool isOnPlateA() {
        return transform.position == gameflow2.plateACoords + gameflow2.addUndercookedCKCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow2.plateBCoords + gameflow2.addUndercookedCKCoords;
    }
}


