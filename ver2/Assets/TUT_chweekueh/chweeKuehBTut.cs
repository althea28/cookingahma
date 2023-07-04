using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chweeKuehBTut : MonoBehaviour
{
    private bool addedCookedSteam = false;
    public Transform cookedSteamObj;
    public Transform cookedCkObj;

    // Start is called before the first frame update
    void Start()
    {
        addedCookedSteam = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == 7) && (isOnSteamerB()) && (!addedCookedSteam)) {
            Instantiate(cookedSteamObj, transform.position, cookedSteamObj.rotation);
            addedCookedSteam = true;
        }
    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == 7) && (isOnSteamerB())) {
            Destroy (gameObject);
            Instantiate (cookedCkObj, 
                ckTutFlow.plateACoords + ckTutFlow.addCookedCKCoords, cookedCkObj.rotation);
            ckTutFlow.stepCounter ++;
        }
    }

    bool isOnSteamerB() {
        return transform.position == ckTutFlow.steamerBCoords;
    }
}
