using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overcookedEggTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((sbeTutFlow.stepCounter == sbeTutFlow.stepTrashBurnt) && (isOnPlateA())) {
           Destroy (gameObject);
       }
           
    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepMoveBurnt) && (isOnPlateA())) {
            sbeTutFlow.stepCounter ++;
        }
    }

    bool isOnPlateA() {
        return transform.position == 
            sbeTutFlow.plateACoords + sbeTutFlow.addOvercookedEggsCoords;
    }
}
