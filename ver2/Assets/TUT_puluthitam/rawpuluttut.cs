using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rawpuluttut : MonoBehaviour
{
    private bool destroyedA = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((pulutTutFlow.stepCounter == 10) && (!destroyedA) && (isOnBowlA())) {
            destroyedA = true;
            Destroy(gameObject);
        }

    }
    void OnMouseDown() {
        if ((pulutTutFlow.stepCounter == 8) && (isOnBowlA())) {
            pulutTutFlow.stepCounter++;
        }
    }

    bool isOnBowlA() {
        return transform.position == pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords;
    }
    bool isOnBowlB() {
        return transform.position == pulutTutFlow.bowlBCoords + pulutTutFlow.addPulutCoords;
    }

}
