using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerOndehTut : MonoBehaviour
{
    public Transform ondehReqObj;

    // Start is called before the first frame update
    void Start()
    {
       Instantiate(ondehReqObj, transform.position + ondehTutFlow.addReqCoordinates, ondehReqObj.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if ((ondehTutFlow.stepCounter == 11) && (isOnCusBCoords())) {
            ondehTutFlow.stepCounter ++;
            Destroy (gameObject);
        } else if ((ondehTutFlow.stepCounter == 16)) {
            ondehTutFlow.stepCounter ++;
            Destroy (gameObject);
        }
    }

    bool isOnCusBCoords() {
        return transform.position == ondehTutFlow.customerBCoordinates;
    }
}
