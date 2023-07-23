using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class precutvegTut : MonoBehaviour
{
    public Transform cutVegObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepClickKnifeB) { //to cut vege
            Instantiate(cutVegObj, rojakTutFlow.boardACoords + rojakTutFlow.addCutVegeBoardCoords, cutVegObj.rotation);
            Destroy(gameObject);
            rojakTutFlow.stepCounter++;
                }
            
            //reset

    }
}
