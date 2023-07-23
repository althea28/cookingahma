using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggCTut : MonoBehaviour
{
    private bool addedCookedSteam = false;
    private bool addedOvercookedSteam = false;

    public Transform cookedSteamObj;
    public Transform overcookedSteamObj;
    public Transform overcookedEggsObj;

    // Start is called before the first frame update
    void Start()
    {
        addedCookedSteam = false; 
        addedOvercookedSteam = false;
       
    }

    // Update is called once per frame
    void Update()
    {
       if ((sbeTutFlow.stepCounter == sbeTutFlow.stepAddSoya) && (isOnSteamerA()) && (!addedCookedSteam)) {
           Instantiate(cookedSteamObj, transform.position, cookedSteamObj.rotation);
           addedCookedSteam = true;
       } else if ((sbeTutFlow.stepCounter == sbeTutFlow.stepServeCustomer) && (isOnSteamerA()) && (!addedOvercookedSteam)) {
           Instantiate(overcookedSteamObj, transform.position, overcookedSteamObj.rotation);
           addedOvercookedSteam = true;
       }
    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepServeCustomer) && (isOnSteamerA())) {
            sbeTutFlow.stepCounter ++;
            Instantiate(overcookedEggsObj, 
                sbeTutFlow.plateACoords + sbeTutFlow.addOvercookedEggsCoords, overcookedEggsObj.rotation);
            Destroy (gameObject);
        }
    }

    bool isOnSteamerA() {
        return transform.position == sbeTutFlow.steamerACoords;
    }
}
