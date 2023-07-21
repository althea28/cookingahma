using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkbowltut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (pulutTutFlow.stepCounter == 14) {
            pulutTutFlow.stepCounter ++;
        }
    }
}
