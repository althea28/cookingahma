using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedOndehTut : MonoBehaviour
{
    public Transform coconutObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        if ((ondehTutFlow.stepCounter == ondehTutFlow.stepServeCustomer) && 
                (transform.position == ondehTutFlow.plateACoords + ondehTutFlow.cookedOndehCoords))  {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepClickCoconut) 
        {
            Instantiate(coconutObj, transform.position + ondehTutFlow.addCoconutCoords, coconutObj.rotation);
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == ondehTutFlow.stepAddCoconut) {
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == ondehTutFlow.stepClickToServe) {
            Destroy (gameObject);
        }
    }
}
