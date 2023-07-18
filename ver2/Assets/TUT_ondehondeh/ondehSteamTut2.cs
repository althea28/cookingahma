using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehSteamTut2 : MonoBehaviour
{
    public Transform cookedOndehObj;
    public Transform overcookedOndehObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ondehTutFlow.stepCounter == 9) 
        {
            Instantiate(cookedOndehObj, ondehTutFlow.steamerBCoords + ondehTutFlow.addBoilingOndehCoords, cookedOndehObj.rotation);
        }
        else if (ondehTutFlow.stepCounter == 10) 
        {
            Instantiate(overcookedOndehObj, ondehTutFlow.steamerBCoords + ondehTutFlow.addBoilingOndehCoords, overcookedOndehObj.rotation);
        }
        else if (ondehTutFlow.stepCounter == 11)
        {
            Destroy (gameObject);
        }
    }
}
