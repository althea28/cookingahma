using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashSbeTut : MonoBehaviour
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
        if ((sbeTutFlow.stepCounter == 5) || (sbeTutFlow.stepCounter == 14)) {
            sbeTutFlow.stepCounter ++;
        }
    }
}
