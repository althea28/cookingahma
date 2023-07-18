using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burntOndehTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ondehTutFlow.stepCounter == 13) 
        {
            Destroy (gameObject);
        }
    }

    void OnMouseDown() 
    {
        if (ondehTutFlow.stepCounter == 11) 
        {
            ondehTutFlow.stepCounter++;
        }

    }
}
