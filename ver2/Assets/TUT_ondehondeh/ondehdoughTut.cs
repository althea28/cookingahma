using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehdoughTut : MonoBehaviour
{
    public Transform steamObj;
    public Transform steamObj2;
    public Transform steamObj3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepAddSugarA) {
            Instantiate(steamObj, ondehTutFlow.steamerACoords, steamObj.rotation);
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == ondehTutFlow.stepAddSugarB) {
            Instantiate(steamObj2, ondehTutFlow.steamerBCoords, steamObj2.rotation);
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == ondehTutFlow.stepAddSugarC) {
            Instantiate(steamObj3, ondehTutFlow.steamerACoords, steamObj3.rotation);
            ondehTutFlow.stepCounter++;
        }
    }
}
