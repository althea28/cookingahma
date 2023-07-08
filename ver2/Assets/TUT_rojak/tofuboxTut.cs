using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tofuboxTut : MonoBehaviour
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
        if (rojakTutFlow.stepCounter == 9) {
            Instantiate(precutTofuObj, rojakTutFlow.boardACoords + rojakTutFlow.addFruitsBoardCoords, precutTofuObj.rotation);
            rojakTutFlow.stepCounter ++;
        }
    }

}