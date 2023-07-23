using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class overcookedegg : MonoBehaviour
{

    public Transform ocSoyaSauceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.trashPlateA) && (isOnPlateA())) {
            
            checkSoyaA();
            /*if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
                ocSoyasauce.trashSoyaA = true;
            }*/

            gameflow.trashPlateA = false;
            resetA();
            Destroy (gameObject);
        } else if ((gameflow.trashPlateB) && (isOnPlateB())) {

            checkSoyaB();
            /*if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
                ocSoyasauce.trashSoyaB = true;
            }*/
            gameflow.trashPlateB = false;
            resetB();
            Destroy (gameObject);
        }
        
    }

    void OnMouseDown() {
        if (gameflow.soyaSauceClicked) {
            Instantiate(ocSoyaSauceObj, 
                transform.position + gameflow.addOCSoyaSauceCoords, ocSoyaSauceObj.rotation);
            addedSoya(); //indicate in gameflow that added soya sauce
            gameflow.soyaSauceClicked = false;

            //RESET===
            gameflow.resetClicks = true; 

        } else if (isOnPlateA()) {
            gameflow.plateAClicked = true;

            //RESET===
            gameflow.resetClicksToast = true;
            gameflow.plateBClicked = false;

        } else if (isOnPlateB()) {
            gameflow.plateBClicked = true;
            
            //RESET===
            gameflow.resetClicksToast = true;
            gameflow.plateAClicked = false;

        }
    }

    void checkSoyaA() {
        if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
            ocSoyasauce.trashSoyaA = true;
        }
    }
    void checkSoyaB() {
        if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
            ocSoyasauce.trashSoyaB = true;
        }
    }

    void resetA() {
        gameflow.hasSoyaOnA = false;
        gameflow.eggsOnPlateA = false;
        //gameflow.plateACooked = false;
    }

    void resetB() {
        gameflow.hasSoyaOnB = false;
        gameflow.eggsOnPlateB = false;
        //gameflow.plateBCooked = false;

    }
 

    void addedSoya() {
        if (isOnPlateA()) {
            gameflow.hasSoyaOnA = true;
        } else if (isOnPlateB()) {
            gameflow.hasSoyaOnB = true;
        }
    }

    bool isOnPlateA() {
        return transform.position == gameflow.plateACoords + gameflow.addOvercookedEggsCoords;
    }
    bool isOnPlateB() {
        return transform.position == gameflow.plateBCoords + gameflow.addOvercookedEggsCoords;
    }




}
