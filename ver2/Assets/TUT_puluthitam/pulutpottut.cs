using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulutpottut : MonoBehaviour
{
    public Transform rawPulutObj;
    public Transform cookedPulutObj;
    public Transform burntPulutObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if ((pulutTutFlow.stepCounter == 7) && (isPotA())) {
            Instantiate(rawPulutObj, pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords, rawPulutObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if ((pulutTutFlow.stepCounter == 13) && (isPotB())) {
            Instantiate(cookedPulutObj, pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords, cookedPulutObj.rotation);
            pulutTutFlow.stepCounter++;
        } else if ((pulutTutFlow.stepCounter == 18) && (isPotA())) {
            Instantiate(burntPulutObj, pulutTutFlow.bowlACoords + pulutTutFlow.addPulutCoords, burntPulutObj.rotation);
            pulutTutFlow.stepCounter++;
        }

    }

    bool isPotA() {
        return transform.position == pulutTutFlow.potACoords;
    }
    bool isPotB() {
        return transform.position == pulutTutFlow.potBCoords;
    }
    
}
