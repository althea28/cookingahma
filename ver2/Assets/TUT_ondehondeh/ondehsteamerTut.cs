using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehsteamerTut : MonoBehaviour
{
    public Transform undercookedOndehObj;
    public Transform burntOndehObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        if (ondehTutFlow.stepCounter == 5) {
            Instantiate(undercookedOndehObj, ondehTutFlow.plateACoords + ondehTutFlow.undercookedOndehCoords, undercookedOndehObj.rotation);
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == 10) {
            Instantiate(burntOndehObj, ondehTutFlow.plateACoords + ondehTutFlow.overcookedOndehCoords, burntOndehObj.rotation);
            ondehTutFlow.stepCounter++;
        }
    }
}
