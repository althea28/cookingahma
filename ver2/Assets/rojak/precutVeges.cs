using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class precutVeges : MonoBehaviour
{
    public Transform cutVegeObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (gameflow2.knifeClicked) {
            Instantiate(cutVegeObj, getCutVegeCoords(), cutVegeObj.rotation);
            Destroy(gameObject);

            //reset
            gameflow2.resetClicksRojak = true;

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


    Vector3 getCutVegeCoords() {
        if (isOnBoardA()) {
            return gameflow2.boardACoords + gameflow2.addCutVegeBoardCoords;
        } else {
            return gameflow2.boardBCoords + gameflow2.addCutVegeBoardCoords;
        }
    }

    bool isOnBoardA() {
        return transform.position == gameflow2.boardACoords + gameflow2.addVegeBoardCoords;
    }
    bool isOnBoardB() {
        return transform.position == gameflow2.boardBCoords + gameflow2.addVegeBoardCoords;
    }

     
}
