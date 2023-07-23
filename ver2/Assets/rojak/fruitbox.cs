using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class fruitbox : MonoBehaviour
{
    public Transform precutFruitsObj;

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
            Instantiate(precutFruitsObj, gameflow2.boardACoords + gameflow2.addFruitsBoardCoords, precutFruitsObj.rotation);
            gameflow2.foodOnBoardA = true;

        } else if (!gameflow2.foodOnBoardB) {
            Instantiate(precutFruitsObj, gameflow2.boardBCoords + gameflow2.addFruitsBoardCoords, precutFruitsObj.rotation);
            gameflow2.foodOnBoardB = true;
        } 
    }
}
