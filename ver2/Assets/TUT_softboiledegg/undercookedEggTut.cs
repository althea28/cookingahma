using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class undercookedEggTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == 6) && (isOnPlateA())) {
            Destroy (gameObject);
        }
    }

    void OnMouseDown() {
        if (sbeTutFlow.stepCounter == 4) {
            sbeTutFlow.stepCounter ++;
        }
    }

    bool isOnPlateA() {
        return transform.position == 
                sbeTutFlow.plateACoords + sbeTutFlow.addUndercookedEggsCoords;
    }

}
