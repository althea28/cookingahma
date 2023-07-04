using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chweeKuehCTut : MonoBehaviour
{
    private bool addedCookedSteam = false;

    public Transform cookedSteamObj;
    public Transform overcookedCkObj;

    // Start is called before the first frame update
    void Start()
    {
        addedCookedSteam = false; 
       
    }

    // Update is called once per frame
    void Update()
    {
       if ((ckTutFlow.stepCounter == 10) && (isOnSteamerA()) && (!addedCookedSteam)) {
           Instantiate(cookedSteamObj, transform.position, cookedSteamObj.rotation);
           addedCookedSteam = true;
      /* } else if ((ckTutFlow.stepCounter == 12) && (isOnSteamerA()) {
           Instantiate(overcookedSteamObj, transform.position, overcookedSteamObj.rotation);
           addedOvercookedSteam = true;*/ 
           // ^^ To edit this part to change to the golden chwee kueh
       }
    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == 12) && (isOnSteamerA())) {
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
