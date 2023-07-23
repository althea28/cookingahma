using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehTrashTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepClickUndercooked) 
        {
            ondehTutFlow.stepCounter++;
        }

        if (ondehTutFlow.stepCounter == ondehTutFlow.stepClickOvercooked)
        {
            ondehTutFlow.stepCounter++;
        }
    }
}
