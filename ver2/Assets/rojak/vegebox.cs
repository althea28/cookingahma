using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegebox : MonoBehaviour
{
    public Transform precutVegeObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        gameflow2.resetClicks = true; 

        if (!gameflow2.foodOnBoardA) {
            Instantiate(precutVegeObj, gameflow2.boardACoords + gameflow2.addVegeBoardCoords, precutVegeObj.rotation);
            gameflow2.foodOnBoardA = true;

        } else if (!gameflow2.foodOnBoardB) {
            Instantiate(precutVegeObj, gameflow2.boardBCoords + gameflow2.addVegeBoardCoords, precutVegeObj.rotation);
            gameflow2.foodOnBoardB = true;
        } 
    }

}
