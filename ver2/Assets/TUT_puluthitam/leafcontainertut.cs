using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafcontainertut : MonoBehaviour
{
    public Transform leafObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (pulutTutFlow.stepCounter == 3) {
            Instantiate(leafObj, pulutTutFlow.potACoords + pulutTutFlow.addPandanCoords, leafObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if (pulutTutFlow.stepCounter == 4) {
            Instantiate(leafObj, pulutTutFlow.potBCoords + pulutTutFlow.addPandanCoords, leafObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if (pulutTutFlow.stepCounter == 11) {
            Instantiate(leafObj, pulutTutFlow.potACoords + pulutTutFlow.addPandanCoords, leafObj.rotation);
            pulutTutFlow.stepCounter++;
        }
    }
}
