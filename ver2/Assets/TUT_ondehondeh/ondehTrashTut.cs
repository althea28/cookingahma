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
        if (ondehTutFlow.stepCounter == 7) 
        {
            ondehTutFlow.stepCounter++;
        }

        if (ondehTutFlow.stepCounter == 12)
        {
            ondehTutFlow.stepCounter++;
        }
    }
}
