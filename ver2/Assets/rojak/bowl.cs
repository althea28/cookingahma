using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class bowl : MonoBehaviour
{
    public Transform sauceObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  
    }

    void OnMouseDown() {
        if ((gameflow2.sauceClicked) && (getCurrentStep() == gameflow2.stepPlateWithTofu)) { //adding sauce
            Instantiate(sauceObj, transform.position, sauceObj.rotation);
            nextStep();

            //RESET
            gameflow2.resetClicksRojak = true;

        } else if (getCurrentStep() == gameflow2.stepReadyPlate) { //serving to customer

            clickBowl();
            /*if (isBowlA()) {
              gameflow2.bowlAClicked = true;
            //RESET
            gameflow2.bowlBClicked = false;

            } else if (isBowlB()) {
            gameflow2.bowlBClicked = true;
            //RESET
            gameflow2.bowlAClicked = false;
            }*/

            //RESET
            gameflow2.knifeClicked = false;
            gameflow2.sauceClicked = false;
            gameflow2.boardAClicked = false;
            gameflow2.boardBClicked = false;        
        }
        //RESET
        gameflow2.resetClicksChweeKueh = true;
    }

    void clickBowl(){
        if (isBowlA()) {
            gameflow2.bowlAClicked = true;
            //RESET
            gameflow2.bowlBClicked = false;

        } else if (isBowlB()) {
            gameflow2.bowlBClicked = true;
            //RESET
            gameflow2.bowlAClicked = false;
        }
    }


    bool isBowlA() {
        return transform.position == gameflow2.bowlACoords;
    }
    bool isBowlB() {
        return transform.position == gameflow2.bowlBCoords;
    }

    int getCurrentStep() {
        if (transform.position == gameflow2.bowlACoords) { //is bowl A
            return gameflow2.stepOnBowlA;
        } else { //is bowl B
            return gameflow2.stepOnBowlB;
        }
    }

    void nextStep() {
        if (transform.position == gameflow2.bowlACoords) { //is bowl A
            gameflow2.stepOnBowlA ++;
        } else { //is bowl B
            gameflow2.stepOnBowlB ++;
        }
    }


}
