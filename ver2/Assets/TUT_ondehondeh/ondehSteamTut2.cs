using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehSteamTut2 : MonoBehaviour
{
    public Transform cookedOndehObj;
    public Transform overcookedOndehObj;
    private static bool addedCooked = false;
    private static bool addedOvercooked = false;

    // Start is called before the first frame update
    void Start()
    {
        addedCooked = false;
        addedOvercooked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((ondehTutFlow.stepCounter == ondehTutFlow.stepTrashUndercooked) && (!addedCooked)) 
        {
            addedCooked = true;
            Instantiate(cookedOndehObj, ondehTutFlow.steamerBCoords + ondehTutFlow.addBoilingOndehCoords, cookedOndehObj.rotation);
        }
        else if ((ondehTutFlow.stepCounter == ondehTutFlow.stepBoilDoughC) && (!addedOvercooked))
        {
            addedOvercooked = true;
            Instantiate(overcookedOndehObj, ondehTutFlow.steamerBCoords + ondehTutFlow.addBoilingOndehCoords, overcookedOndehObj.rotation);
        }
        else if (ondehTutFlow.stepCounter == ondehTutFlow.stepMoveOvercooked)
        {
            Destroy (gameObject);
        }
    }
}
