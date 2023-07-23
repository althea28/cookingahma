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
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepTrashOvercooked) 
        {
            Destroy (gameObject);
        }
    }

    void OnMouseDown() 
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepMoveOvercooked) 
        {
            ondehTutFlow.stepCounter++;
        }

    }
}
