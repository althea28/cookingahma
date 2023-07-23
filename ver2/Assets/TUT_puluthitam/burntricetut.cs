using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burntricetut : MonoBehaviour
{
    public Transform burntPulutObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((pulutTutFlow.stepCounter == pulutTutFlow.stepMoveBurnt) && (isOnPotA())) {
           Destroy(gameObject);
       }
    }

    bool isOnPotA() {
        return transform.position == pulutTutFlow.potACoords + pulutTutFlow.addRiceCoords;
    }
}
