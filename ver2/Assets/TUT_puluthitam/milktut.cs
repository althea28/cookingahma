using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milktut : MonoBehaviour
{
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

    bool isOnBowlA() {
        return transform.position == pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords + pulutTutFlow.addMilkCoords;
    }
}
