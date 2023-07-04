using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerCkTut : MonoBehaviour
{
    public Transform ckReqObj;

    // Start is called before the first frame update
    void Start()
    {
       Instantiate(ckReqObj, transform.position + ckTutFlow.addReqCoordinates, ckReqObj.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if ((ckTutFlow.stepCounter == 11) && (isOnCusBCoords())) {
            ckTutFlow.stepCounter ++;
            Destroy (gameObject);
        }
    }

    bool isOnCusBCoords() {
        return transform.position == ckTutFlow.customerBCoordinates;
    }
}
