using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconutbowlTut : MonoBehaviour
{

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
        if (ondehTutFlow.stepCounter == 14) 
        {
            ondehTutFlow.stepCounter++;
        }
    }
}
