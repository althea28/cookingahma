using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulutreqtut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((pulutTutFlow.stepCounter == pulutTutFlow.stepServeCustomer) && 
                (transform.position == pulutTutFlow.customerBCoordinates + pulutTutFlow.addReqCoordinates)) {
           Destroy(gameObject);
       }
    }
}
