using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reqSbeTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepServeCustomer) && (isOnCusBReqCoords())) {
            Destroy (gameObject);
        }
        
    }

    bool isOnCusBReqCoords() {
        return transform.position == 
            sbeTutFlow.customerBCoordinates + sbeTutFlow.addReqCoordinates;
    }
}
