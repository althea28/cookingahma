using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerRojakTut : MonoBehaviour
{
    public Transform rojakReqObj;

    // Start is called before the first frame update
    void Start()
    {
       Instantiate(rojakReqObj, transform.position + rojakTutFlow.addReqCoordinates, rojakReqObj.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if ((rojakTutFlow.stepCounter == rojakTutFlow.stepClickKnifeC) && (isOnCusBCoords())) {
            rojakTutFlow.stepCounter ++;
            Destroy (gameObject);
        } else if ((rojakTutFlow.stepCounter == rojakTutFlow.stepClickRojak)) {
            rojakTutFlow.stepCounter ++;
            Destroy (gameObject);
        }
    }

    bool isOnCusBCoords() {
        return transform.position == rojakTutFlow.customerBCoordinates;
    }
}
