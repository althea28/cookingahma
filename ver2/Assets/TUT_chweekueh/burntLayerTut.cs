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
        if ((ckTutFlow.stepCounter == 13) && (isOnCK())) {
            Destroy (gameObject);
        }
        
    }

    bool isOnCK() {
        return transform.position == ckTutFlow.steamerACoords + ckTutFlow.burntLayerCoords;
    }
}
