using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugartut : MonoBehaviour
{
    private bool destroyedA = false;
    private bool destroyedB = false;
    private bool destroyedC = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((pulutTutFlow.stepCounter == 8) && (isOnPotA()) && (!destroyedA)) {
           destroyedA = true;
           Destroy(gameObject);
       } else if ((pulutTutFlow.stepCounter == 11) && (isOnPotB()) && (!destroyedB)) {
           destroyedB = true;
           Destroy(gameObject);
       } else if ((pulutTutFlow.stepCounter == 15) && (isOnPotA()) && (!destroyedC)) {
           destroyedC = true;
           Destroy(gameObject);
       }
    }

    bool isOnPotA() {
        return transform.position == pulutTutFlow.potACoords + pulutTutFlow.addSugarCoords;
    }
    bool isOnPotB() {
        return transform.position == pulutTutFlow.potBCoords + pulutTutFlow.addSugarCoords;
    }

}
