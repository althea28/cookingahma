using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ricebuckettut : MonoBehaviour
{
    public Transform rawRiceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (pulutTutFlow.stepCounter == pulutTutFlow.stepStart) {
            Instantiate(rawRiceObj, pulutTutFlow.potACoords + pulutTutFlow.addRiceCoords, rawRiceObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if (pulutTutFlow.stepCounter == pulutTutFlow.stepAddRiceA) {
            Instantiate(rawRiceObj, pulutTutFlow.potBCoords + pulutTutFlow.addRiceCoords, rawRiceObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if (pulutTutFlow.stepCounter == pulutTutFlow.stepTrashUndercooked) {
            Instantiate(rawRiceObj, pulutTutFlow.potACoords + pulutTutFlow.addRiceCoords, rawRiceObj.rotation);
            pulutTutFlow.stepCounter++;
        }

 
    }
}
