using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chweeKuehATut : MonoBehaviour
{
    public Transform undercookedCkObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == 3) && (isOnSteamerA())) {

            Instantiate(undercookedCkObj, 
                ckTutFlow.plateACoords + ckTutFlow.addUndercookedCKCoords, 
                undercookedCkObj.rotation);
            Destroy (gameObject);
            ckTutFlow.stepCounter ++;
        }
    }

    bool isOnSteamerA() {
        return transform.position == ckTutFlow.steamerACoords;
    }
}
