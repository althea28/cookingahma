using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class undercookedCkTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepTrashUndercooked) && (isOnPlateA())) {
            Destroy (gameObject);
        }
    }

    void OnMouseDown() {
        if (ckTutFlow.stepCounter == ckTutFlow.stepMoveUndercooked) {
            ckTutFlow.stepCounter ++;
        }
    }

    bool isOnPlateA() {
        return transform.position == 
                ckTutFlow.plateACoords + ckTutFlow.addUndercookedCKCoords;
    }

}
