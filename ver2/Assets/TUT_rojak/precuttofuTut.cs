using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class precuttofuTut : MonoBehaviour
{
    public Transform cutTofuObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepClickKnifeC) { //to cut tofu
            Instantiate(cutTofuObj, rojakTutFlow.boardACoords + rojakTutFlow.addCutTofuBoardCoords, cutTofuObj.rotation);
            Destroy(gameObject);
            rojakTutFlow.stepCounter++;
                }
            
            //reset

    }
}
