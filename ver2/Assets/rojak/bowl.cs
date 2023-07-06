using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if ((gameflow2.sauceClicked) && (getCurrentStep() == 4)) { //adding sauce
            Instantiate(sauceObj, transform.position, sauceObj.rotation);
            nextStep();

            //RESET
            gameflow2.resetClicksRojak = true;

        } else if (getCurrentStep() == 5) { //serving to customer
            if (isBowlA()) {
                gameflow2.bowlAClicked = true;
                //RESET
                gameflow2.bowlBClicked = false;

            } else if (isBowlB()) {
                gameflow2.bowlBClicked = true;
                //RESET
                gameflow2.bowlAClicked = false;
            }
            //RESET
            gameflow2.knifeClicked = false;
            gameflow2.sauceClicked = false;
            gameflow2.boardAClicked = false;
            gameflow2.boardBClicked = false;        
        }
        //RESET
        gameflow2.resetClicksChweeKueh = true;
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
