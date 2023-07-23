using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rawEgg : MonoBehaviour
{

    public Transform soyaSauceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //trying to trash OR serve => destroy obj
        if (((gameflow.trashPlateA) && (isOnPlateA())) || (((gameflow.serveEggA) && (isOnPlateA()))))  {
            
            checkSoyaA();
            /*if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
                soyasauce.trashSoyaA = true;
            }*/

            gameflow.trashPlateA = false;
            gameflow.serveEggA = false;

            resetA();
            Destroy (gameObject);

        } else if (((gameflow.trashPlateB) && (isOnPlateB())) || ((gameflow.serveEggB) && (isOnPlateB()))) {

            checkSoyaB();
            /*if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
                soyasauce.trashSoyaB = true;
            }*/

            gameflow.trashPlateB = false;
            gameflow.serveEggB = false;

            resetB();
            Destroy (gameObject);
        }
            
        
    }

    void OnMouseDown() {
        if ((gameflow.soyaSauceClicked) && (canAddSoyaSauce())) {
            //add soya sauce to egg
            Instantiate(soyaSauceObj, transform.position + gameflow.addSoyaSauceCoords, soyaSauceObj.rotation);
            addedSoya(); //indicate in gameflow that added soya sauce
            
            //RESET===
            gameflow.resetClicksEggs = true;

        } else if (isOnPlateA()) {
            gameflow.plateAClicked = true;

            //RESET===
            gameflow.plateBClicked = false;

        } else if (isOnPlateB()) {
            gameflow.plateBClicked = true;

            //RESET===
            gameflow.plateAClicked = false;

        }
        gameflow.soyaSauceClicked = false;
        gameflow.resetClicksToast = true;

    }
    void checkSoyaA() {
        if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
            soyasauce.trashSoyaA = true;
        }
    }
    void checkSoyaB() {
        if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
            soyasauce.trashSoyaB = true;
        }
    }

    bool canAddSoyaSauce() {
        if (isOnPlateA()) {
            return (!gameflow.hasSoyaOnA);
        } else { //is on plate B
            return (!gameflow.hasSoyaOnB);
        }
    }

   
    void resetA() { //to reset added soya, is on plate A
        gameflow.hasSoyaOnA = false;
        gameflow.eggsOnPlateA = false;
        gameflow.plateACooked = false;
    }
    
    void resetB() { //to reset added soya, is on plate A
        gameflow.hasSoyaOnB = false;
        gameflow.eggsOnPlateB = false;
        gameflow.plateBCooked = false;

    }

    void addedSoya() {
        if (isOnPlateA()) {
            gameflow.hasSoyaOnA = true;
        } else if (isOnPlateB()) {
            gameflow.hasSoyaOnB = true;
        }
    }

    bool isOnPlateA() {
        return transform.position == gameflow.plateACoords + gameflow.addUndercookedEggsCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow.plateBCoords + gameflow.addUndercookedEggsCoords;
    }

}
