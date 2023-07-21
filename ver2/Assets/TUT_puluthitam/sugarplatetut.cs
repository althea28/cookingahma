using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarplatetut : MonoBehaviour
{
    public Transform sugarObj;
    public Transform steamObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown() {
        if (pulutTutFlow.stepCounter == 5) {
            Instantiate(sugarObj, pulutTutFlow.potACoords + pulutTutFlow.addSugarCoords, sugarObj.rotation);
            Instantiate(steamObj, pulutTutFlow.potACoords, steamObj.rotation);
            pulutTutFlow.stepCounter ++;
        } else if (pulutTutFlow.stepCounter == 6) {
            Instantiate(sugarObj, pulutTutFlow.potBCoords + pulutTutFlow.addSugarCoords, sugarObj.rotation);
            Instantiate(steamObj, pulutTutFlow.potBCoords, steamObj.rotation);
            pulutTutFlow.stepCounter ++;
        } else if (pulutTutFlow.stepCounter == 12) {
            Instantiate(sugarObj, pulutTutFlow.potACoords + pulutTutFlow.addSugarCoords, sugarObj.rotation);
            Instantiate(steamObj, pulutTutFlow.potACoords, steamObj.rotation);
            pulutTutFlow.stepCounter ++;
        } 

    }

}
