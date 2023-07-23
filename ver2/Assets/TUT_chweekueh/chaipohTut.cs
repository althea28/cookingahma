using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaipohTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepServeCustomer) && (isOnPlateA())) {
            Destroy (gameObject);
        }
        
    }

    bool isOnPlateA() {
        return transform.position == ckTutFlow.plateACoords + 
            ckTutFlow.addCookedCKCoords + ckTutFlow.addCookedCP;
    }
}
