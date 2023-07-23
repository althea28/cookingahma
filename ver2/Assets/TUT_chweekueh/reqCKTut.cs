using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reqCKTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepServeCustomer) && (isOnCusBReqCoords())) {
            Destroy (gameObject);
        }
        
    }

    bool isOnCusBReqCoords() {
        return transform.position == 
            ckTutFlow.customerBCoordinates + ckTutFlow.addReqCoordinates;
    }
}
