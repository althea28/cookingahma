using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehSteamTut3 : MonoBehaviour
{
    public Transform cookedOndehObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (ondehTutFlow.stepCounter == 12)
        {
            Instantiate(cookedOndehObj, ondehTutFlow.steamerACoords + ondehTutFlow.addBoilingOndehCoords, cookedOndehObj.rotation);
        }
        else if (ondehTutFlow.stepCounter == 14)
        {
            Destroy(gameObject);
        }
    }
}
