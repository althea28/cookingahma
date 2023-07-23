using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutvege : MonoBehaviour
{
    public Transform platedVegeObj;
    private int ingredientStep = gameflow2.stepPlateWithFruit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //check if trashing
        if ((gameflow2.trashBoardA) && (isOnBoardA())) {
            //resetBoardA();
            gameflow2.foodOnBoardA = false;
            Destroy(gameObject);
            gameflow2.trashBoardA = false;
        } else if ((gameflow2.trashBoardB) && (isOnBoardB())) {
            //resetBoardB();
            gameflow2.foodOnBoardB = false;
            Destroy(gameObject);
            gameflow2.trashBoardB = false;
        }
        
    }

    void OnMouseDown() {
        //move to bowls
        if ((isOnBoardA()) && 
                ((gameflow2.stepOnBowlA == ingredientStep) || 
                (gameflow2.stepOnBowlB == ingredientStep))) {
            Instantiate(platedVegeObj, getBowlCoords(), platedVegeObj.rotation);
            gameflow2.foodOnBoardA = false;
            Destroy(gameObject);
            
            //reset       
            gameflow2.resetClicksRojak = true;

        } else if ((isOnBoardB()) && 
                ((gameflow2.stepOnBowlA == ingredientStep) || 
                (gameflow2.stepOnBowlB == ingredientStep))) {
            Instantiate(platedVegeObj, getBowlCoords(), platedVegeObj.rotation);
            gameflow2.foodOnBoardB = false;
            Destroy(gameObject);

            //reset       
            gameflow2.resetClicksRojak = true;
        
        //for trashing
        } else if (isOnBoardA()) {
            gameflow2.boardAClicked = true;
             
            //reset
            gameflow2.knifeClicked = false;
            gameflow2.sauceClicked = false;   
            gameflow2.boardBClicked = false;
            gameflow2.bowlAClicked = false;
            gameflow2.bowlBClicked = false;

        } else if (isOnBoardB()) {
            gameflow2.boardBClicked = true;
            
            //reset        
            gameflow2.knifeClicked = false;
            gameflow2.sauceClicked = false;
            gameflow2.boardAClicked = false;
            gameflow2.bowlAClicked = false;
            gameflow2.bowlBClicked = false;
        }
        
        //reset
        gameflow2.resetClicksChweeKueh = true;
    }

    Vector3 getBowlCoords() {
        if (gameflow2.stepOnBowlA == ingredientStep) {
            gameflow2.stepOnBowlA ++;
            return gameflow2.bowlACoords;
        } else {
            gameflow2.stepOnBowlB ++;
            return gameflow2.bowlBCoords;
        }
    }

    bool isOnBoardA() {
        return transform.position == gameflow2.boardACoords + gameflow2.addCutVegeBoardCoords;
    }
    bool isOnBoardB() {
        return transform.position == gameflow2.boardBCoords + gameflow2.addCutVegeBoardCoords;;
    }



}
