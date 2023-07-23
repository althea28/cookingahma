using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamTut : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepMoveCooked) && (isOnSteamerB())) {
            Destroy (gameObject);
        } else if ((ckTutFlow.stepCounter == ckTutFlow.stepMoveBurnt) && (isOnSteamerA())) {
            Destroy (gameObject);
        }
        
    }
    
    bool isOnSteamerA() {
        return transform.position == ckTutFlow.steamerACoords;
    }

    bool isOnSteamerB() {
        return transform.position == ckTutFlow.steamerBCoords;
    }
}
