using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rojaksauceTut : MonoBehaviour
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
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepMoveTofu) {
            rojakTutFlow.stepCounter ++;
        }
    }

}
