using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burntpuluttut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((pulutTutFlow.stepCounter == pulutTutFlow.stepTrashBurnt) && (isOnBowlA())) {
           Destroy(gameObject);
       }
    }

    void OnMouseDown() {
        if ((pulutTutFlow.stepCounter == pulutTutFlow.stepMoveBurnt) && (isOnBowlA())) {
            pulutTutFlow.stepCounter++;
        }
    }
    bool isOnBowlA() {
        return transform.position == pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords;
    }
}
