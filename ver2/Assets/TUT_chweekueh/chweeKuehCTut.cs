using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chweeKuehCTut : MonoBehaviour
{
    private bool addedCookedSteam = false;
    private bool addedBurntLayer = false;

    public Transform cookedSteamObj;
    public Transform burntLayerObj;
    public Transform overcookedCkObj;


    // Start is called before the first frame update
    void Start()
    {
        addedCookedSteam = false; 
        addedBurntLayer = false;
       
    }

    // Update is called once per frame
    void Update()
    {
       if ((ckTutFlow.stepCounter == ckTutFlow.stepAddCP) && (isOnSteamerA()) && (!addedCookedSteam)) {
           Instantiate(cookedSteamObj, transform.position, cookedSteamObj.rotation);
           addedCookedSteam = true;       
       }
       if ((ckTutFlow.stepCounter == ckTutFlow.stepServeCustomer) && (!addedBurntLayer)) {
           Instantiate(burntLayerObj, transform.position + ckTutFlow.burntLayerCoords, burntLayerObj.rotation);
           addedBurntLayer = true;
       }
    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepServeCustomer) && (isOnSteamerA())) {
            ckTutFlow.stepCounter ++;
            Instantiate(overcookedCkObj, 
                ckTutFlow.plateACoords + ckTutFlow.addOvercookedCKCoords, overcookedCkObj.rotation);
            Destroy (gameObject);
        }
    }

    bool isOnSteamerA() {
        return transform.position == ckTutFlow.steamerACoords;
    }
}
