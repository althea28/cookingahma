using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedChweeKuehTut : MonoBehaviour
{
    public Transform chaiPohObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepServeCustomer) && (isOnPlateA())) {
            Destroy (gameObject);
        }
        
    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == ckTutFlow.stepClickCP) && (isOnPlateA())) {
            Instantiate(chaiPohObj, 
                transform.position + ckTutFlow.addCookedCP, chaiPohObj.rotation);
            ckTutFlow.stepCounter ++;
        } else if ((ckTutFlow.stepCounter == ckTutFlow.stepAddCP) && (isOnPlateA())) {
            ckTutFlow.stepCounter ++;
        }    }

    bool isOnPlateA() {
        return transform.position == ckTutFlow.plateACoords + ckTutFlow.addCookedCKCoords;
    }
}
