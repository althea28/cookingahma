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
       if ((sbeTutFlow.stepCounter == 15) && (isOnPlateA())) {
           Destroy (gameObject);
       }
           
    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == 13) && (isOnPlateA())) {
            sbeTutFlow.stepCounter ++;
        }
    }

    bool isOnPlateA() {
        return transform.position == 
            sbeTutFlow.plateACoords + sbeTutFlow.addOvercookedEggsCoords;
    }
}
