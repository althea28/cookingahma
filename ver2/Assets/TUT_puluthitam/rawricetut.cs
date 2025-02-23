using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rawricetut : MonoBehaviour
{
    public Transform cookedPulutObj;

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
        if ((pulutTutFlow.stepCounter == pulutTutFlow.stepMoveUndercooked) && (isOnPotA()) && (!destroyedA)) {
            destroyedA = true;
            Destroy(gameObject);
        } else if ((pulutTutFlow.stepCounter == pulutTutFlow.stepAddRiceC) && (isOnPotB()) && (!destroyedB)) {
            destroyedB = true;
            Instantiate(cookedPulutObj, transform.position, cookedPulutObj.rotation);
            Destroy(gameObject);
        } else if ((pulutTutFlow.stepCounter == pulutTutFlow.stepClickMilk) && (isOnPotA()) && (!destroyedC)) {
            destroyedC = true;
            Instantiate(cookedPulutObj, transform.position, cookedPulutObj.rotation);
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
