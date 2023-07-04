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
        if ((ckTutFlow.stepCounter == 8) && (isOnSteamerB())) {
            Destroy (gameObject);
        } else if ((ckTutFlow.stepCounter == 13) && (isOnSteamerA())) {
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
