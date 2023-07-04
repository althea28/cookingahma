using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCkTut : MonoBehaviour
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
        if ((ckTutFlow.stepCounter == 5) || (ckTutFlow.stepCounter == 14)) {
            ckTutFlow.stepCounter ++;
        }
    }
}