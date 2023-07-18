using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucOndehTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() 
    {
        if (ondehTutFlow.stepCounter == 8) 
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ondehTutFlow.stepCounter == 6) 
        {
            ondehTutFlow.stepCounter++;
        }
    }
}
