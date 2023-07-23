using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggBTut : MonoBehaviour
{
    private bool addedCookedSteam = false;
    public Transform cookedSteamObj;
    public Transform cookedEggObj;

    // Start is called before the first frame update
    void Start()
    {
        addedCookedSteam = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepAddEggC) && (isOnSteamerB()) && (!addedCookedSteam)) {
            Instantiate(cookedSteamObj, transform.position, cookedSteamObj.rotation);
            addedCookedSteam = true;
        }
    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepAddEggC) && (isOnSteamerB())) {
            Destroy (gameObject);
            Instantiate (cookedEggObj, 
                sbeTutFlow.plateACoords + sbeTutFlow.addCookedEggsCoords, cookedEggObj.rotation);
            sbeTutFlow.stepCounter ++;
        }
    }

    bool isOnSteamerB() {
        return transform.position == sbeTutFlow.steamerBCoords;
    }
}
