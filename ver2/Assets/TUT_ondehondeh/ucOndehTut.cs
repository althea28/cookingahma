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
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepTrashUndercooked) 
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepMoveUndercooked) 
        {
            ondehTutFlow.stepCounter++;
        }
    }
}
