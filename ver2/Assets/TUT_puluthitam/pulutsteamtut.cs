using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulutsteamtut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (((pulutTutFlow.stepCounter == pulutTutFlow.stepMoveUndercooked) && (isOnPotA())) ||
            ((pulutTutFlow.stepCounter == pulutTutFlow.stepMoveCooked) && (isOnPotB())) ||
            ((pulutTutFlow.stepCounter == pulutTutFlow.stepMoveBurnt) && (isOnPotA())))
            {
            Destroy(gameObject);
        }

    }
    bool isOnPotA() {
        return transform.position == pulutTutFlow.potACoords;
    }
    bool isOnPotB() {
        return transform.position == pulutTutFlow.potBCoords;
    }


}
