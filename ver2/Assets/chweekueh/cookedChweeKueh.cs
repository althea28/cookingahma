using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of chwee kueh dish. Supports trashing and serving mechanism.
*/
public class cookedChweeKueh : MonoBehaviour
{
    public Transform cookedChaiPohObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys chwee kueh when trashing or serving the dish/
    */
    void Update()
    {
        //trying to trash OR serve => destroy obj
        if (((gameflow2.trashPlateA) && (isOnPlateA())) || (((gameflow2.serveCkA) && (isOnPlateA()))))  {
            
            checkChaiPohA();
            /*if (gameflow2.hasCPOnA) { //if added chai poh to A, destroy it too.
                cookedChaiPoh.trashChaiPohA = true;
            }*/

            gameflow2.trashPlateA = false;
            gameflow2.serveCkA = false;

            resetA();
            Destroy (gameObject);

        } else if (((gameflow2.trashPlateB) && (isOnPlateB())) || (((gameflow2.serveCkB) && (isOnPlateB())))) {
            
            checkChaiPohB();
            /*if (gameflow2.hasCPOnB) { //if added chai poh to B, destroy it too
                cookedChaiPoh.trashChaiPohB = true;
            }*/

            gameflow2.trashPlateB = false;
            gameflow2.serveCkB = false;

            resetB();
            Destroy (gameObject);
        }
            
    }

    /* Supports:
     * (i) Adding chai poh
     * (ii) Trashing or serving dish
    */
    void OnMouseDown() {
        if ((gameflow2.chaiPohClicked) && (
            ((isOnPlateA()) && (!gameflow2.hasCPOnA)) || 
            ((isOnPlateB()) && (!gameflow2.hasCPOnB)))) {
            //add chai poh to chwee kueh
            Instantiate(cookedChaiPohObj, transform.position + gameflow2.addCookedCP, cookedChaiPohObj.rotation);
            addedCookedChaiPoh(); //indicate in gameflow2 that added chai poh
           
            
            //RESET===
            gameflow2.resetClicks = true;

        } else if (isOnPlateA()) {
            gameflow2.plateAClicked = true;

            //RESET===
            gameflow2.plateBClicked = false;
            gameflow2.resetClicksRojak = true;

        } else if (isOnPlateB()) {
            gameflow2.plateBClicked = true;

            //RESET===
            gameflow2.plateAClicked = false;
            gameflow2.resetClicksRojak = true;

        }
        gameflow2.chaiPohClicked = false;
    }
   
   /* Checks if there is chai poh on plate A when trashing or serving this dish. If there is, destroy it too.
   */
    void checkChaiPohA() {
        if (gameflow2.hasCPOnA) { //if added chai poh to A, destroy it too.
            cookedChaiPoh.trashChaiPohA = true;
        }
    }

   /* Checks if there is chai poh on plate B when trashing or serving this dish. If there is, destroy it too.
   */
    void checkChaiPohB() {
        if (gameflow2.hasCPOnB) { //if added chai poh to B, destroy it too
                cookedChaiPoh.trashChaiPohB = true;
            }
    }

   /* Reset variables of plate A, so that new chwee kueh can be moved here.
   */
    void resetA() { //to reset added chai poh, is on plate A
        gameflow2.hasCPOnA = false;
        gameflow2.ckOnPlateA = false;
        gameflow2.plateACooked = false;
    }
    
   /* Reset variables of plate B, so that new chwee kueh can be moved here.
   */
    void resetB() { //to reset added chai poh, is on plate A
        gameflow2.hasCPOnB = false;
        gameflow2.ckOnPlateB = false;
        gameflow2.plateBCooked = false;

    }

   /* Indicate in gameflow2 that chai poh has been added here. Used again:
    * (i) to prevent repeated adding of chai poh here
    * (ii) during serving of dish to check if dish has been prepared correctly
   */
    void addedCookedChaiPoh() {
        if (isOnPlateA()) {
            gameflow2.hasCPOnA = true;
        } else if (isOnPlateB()) {
            gameflow2.hasCPOnB = true;
        }
    }
    
    bool isOnPlateA() {
        return transform.position == gameflow2.plateACoords + gameflow2.addCookedCKCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow2.plateBCoords + gameflow2.addCookedCKCoords;
    }
}


