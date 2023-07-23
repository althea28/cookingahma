using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedpuluttut : MonoBehaviour
{
    public Transform milkObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((pulutTutFlow.stepCounter == pulutTutFlow.stepServeCustomer) && (isOnBowlA())) {
            Destroy(gameObject);
        }
    }

    void OnMouseDown() {
        if (pulutTutFlow.stepCounter == pulutTutFlow.stepClickMilk) {
            Instantiate(milkObj, transform.position + pulutTutFlow.addMilkCoords, milkObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if (pulutTutFlow.stepCounter == pulutTutFlow.stepAddMilk) {
            pulutTutFlow.stepCounter++;
        }
    }
    
    bool isOnBowlA() {
        return transform.position == pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords;
    }
}
