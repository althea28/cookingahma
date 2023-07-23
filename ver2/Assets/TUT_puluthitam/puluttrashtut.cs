using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puluttrashtut : MonoBehaviour
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
        if ((pulutTutFlow.stepCounter == pulutTutFlow.stepClickUndercooked) || (pulutTutFlow.stepCounter == pulutTutFlow.stepClickBurnt)) {
            pulutTutFlow.stepCounter ++;
        }
    }
}
