using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overcookedChweeKueh : MonoBehaviour
{
    public Transform overcookedChaiPohObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //trying to trash OR serve => destroy obj
        if (((gameflow2.trashPlateA) && (isOnPlateA())) || (((gameflow2.serveCkA) && (isOnPlateA()))))  {
            if (gameflow2.hasCPOnA) { //if added chai poh to A, destroy it too.
                cookedChaiPoh.trashChaiPohA = true;
            }

            gameflow2.trashPlateA = false;
            gameflow2.serveCkA = false;

            resetA();
            Destroy (gameObject);

        } else if (((gameflow2.trashPlateB) && (isOnPlateB())) || (((gameflow2.serveCkB) && (isOnPlateB())))) {
            if (gameflow2.hasCPOnB) { //if added chai poh to B, destroy it too
                cookedChaiPoh.trashChaiPohB = true;
            }

            gameflow2.trashPlateB = false;
            gameflow2.serveCkB = false;

            resetB();
            Destroy (gameObject);
        }
            
    }
    
    void OnMouseDown() {
        if (gameflow2.chaiPohClicked) {
            //add chai poh to chwee kueh
            Instantiate(overcookedChaiPohObj, transform.position + gameflow2.addOvercookedCP, overcookedChaiPohObj.rotation);
            addedOvercookedChaiPoh(); //indicate in gameflow2 that added chai poh
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
   
    void resetA() { //to reset added chai poh, is on plate A
        gameflow2.hasCPOnA = false;
        gameflow2.ckOnPlateA = false;
        gameflow2.plateACooked = false;
    }
    
    void resetB() { //to reset added chai poh, is on plate A
        gameflow2.hasCPOnB = false;
        gameflow2.ckOnPlateB = false;
        gameflow2.plateBCooked = false;

    }

    void addedOvercookedChaiPoh() {
        if (isOnPlateA()) {
            gameflow2.hasCPOnA = true;
        } else if (isOnPlateB()) {
            gameflow2.hasCPOnB = true;
        }
    }
    
    bool isOnPlateA() {
        return transform.position == gameflow2.plateACoords + gameflow2.addOvercookedCKCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow2.plateBCoords + gameflow2.addOvercookedCKCoords;
    }
}


