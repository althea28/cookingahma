using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burntLayerTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepMoveBurnt) && (isOnCK())) {
            Destroy (gameObject);
        }
        
    }

    bool isOnCK() {
        return transform.position == ckTutFlow.steamerACoords + ckTutFlow.burntLayerCoords;
    }
}
