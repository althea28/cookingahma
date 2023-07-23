using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegboxTut : MonoBehaviour
{
    public Transform precutVegObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepMoveFruit) {
            Instantiate(precutVegObj, rojakTutFlow.boardACoords + rojakTutFlow.addVegeBoardCoords, precutVegObj.rotation);
            rojakTutFlow.stepCounter ++;
        }
    }

}
