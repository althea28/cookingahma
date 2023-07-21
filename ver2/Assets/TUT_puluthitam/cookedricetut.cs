using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedricetut : MonoBehaviour
{
    public Transform burntRiceObj;
    private bool destroyedB = false; 
    private bool destroyedC = false; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((pulutTutFlow.stepCounter == 14) && (isOnPotB()) && (!destroyedB)) {
            destroyedB = true;
            Destroy(gameObject);
        } else if ((pulutTutFlow.stepCounter == 18) && (isOnPotA()) && (!destroyedC)) {
            destroyedC = true;
            Instantiate(burntRiceObj, transform.position, burntRiceObj.rotation);
            Destroy(gameObject);
        }
    }

    bool isOnPotA() {
        return transform.position == pulutTutFlow.potACoords + pulutTutFlow.addRiceCoords;
    }
    bool isOnPotB() {
        return transform.position == pulutTutFlow.potBCoords + pulutTutFlow.addRiceCoords;
    }
}
