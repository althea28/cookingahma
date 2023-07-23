using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soyasauceTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepServeCustomer) && (isOnPlateA())) {
            Destroy (gameObject);
        }
        
    }

    bool isOnPlateA() {
        return transform.position == sbeTutFlow.plateACoords + 
            sbeTutFlow.addCookedEggsCoords + sbeTutFlow.addSoyaSauceCoords;
    }
}
