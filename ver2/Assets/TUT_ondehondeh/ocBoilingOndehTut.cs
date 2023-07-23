using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocBoilingOndehTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() 
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepMoveOvercooked) 
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {

    }
}
