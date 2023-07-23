using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehSteamTut3 : MonoBehaviour
{
    public Transform cookedOndehObj;
    private static bool addedCooked = false;

    // Start is called before the first frame update
    void Start()
    {
        addedCooked = false;
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((ondehTutFlow.stepCounter == ondehTutFlow.stepClickOvercooked) && (!addedCooked))
        {
            addedCooked = true;
            Instantiate(cookedOndehObj, ondehTutFlow.steamerACoords + ondehTutFlow.addBoilingOndehCoords, cookedOndehObj.rotation);
        }
        else if (ondehTutFlow.stepCounter == ondehTutFlow.stepMoveCooked)
        {
            Destroy(gameObject);
        }
    }
}
