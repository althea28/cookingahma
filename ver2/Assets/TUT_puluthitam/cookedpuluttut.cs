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
        if ((pulutTutFlow.stepCounter == 18) && (isOnBowlA())) {
            Destroy(gameObject);
        }
    }

    void OnMouseDown() {
        if (pulutTutFlow.stepCounter == 15) {
            Instantiate(milkObj, transform.position + pulutTutFlow.addMilkCoords, milkObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if (pulutTutFlow.stepCounter == 16) {
            pulutTutFlow.stepCounter++;
        }
    }
    
    bool isOnBowlA() {
        return transform.position == pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords;
    }
}
