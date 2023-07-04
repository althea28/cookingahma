using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overcookedCKTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((ckTutFlow.stepCounter == 15) && (isOnPlateA())) {
           Destroy (gameObject);
       }
           
    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == 13) && (isOnPlateA())) {
            ckTutFlow.stepCounter ++;
        }
    }

    bool isOnPlateA() {
        return transform.position == 
            ckTutFlow.plateACoords + ckTutFlow.addCookedCKCoords;
    }
}
