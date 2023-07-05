using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tofubox : MonoBehaviour
{
    public Transform precutTofuObj;

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
            Instantiate(precutTofuObj, gameflow2.boardACoords + gameflow2.addTofuBoardCoords, precutTofuObj.rotation);
            gameflow2.foodOnBoardA = true;

        } else if (!gameflow2.foodOnBoardB) {
            Instantiate(precutTofuObj, gameflow2.boardBCoords + gameflow2.addTofuBoardCoords, precutTofuObj.rotation);
            gameflow2.foodOnBoardB = true;
        } 
    }

}
