using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedSteamTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepMoveCooked) && (isOnSteamerB())) {
            Destroy (gameObject);
        } else if ((sbeTutFlow.stepCounter == sbeTutFlow.stepMoveBurnt) && (isOnSteamerA())) {
            Destroy (gameObject);
        }
        
    }
    
    bool isOnSteamerA() {
        return transform.position == sbeTutFlow.steamerACoords;
    }

    bool isOnSteamerB() {
        return transform.position == sbeTutFlow.steamerBCoords;
    }
}
