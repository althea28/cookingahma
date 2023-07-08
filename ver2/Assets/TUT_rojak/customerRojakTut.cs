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
        if ((rojakTutFlow.stepCounter == 11) && (isOnCusBCoords())) {
            rojakTutFlow.stepCounter ++;
            Destroy (gameObject);
        } else if ((rojakTutFlow.stepCounter == 16)) {
            rojakTutFlow.stepCounter ++;
            Destroy (gameObject);
        }
    }

    bool isOnCusBCoords() {
        return transform.position == rojakTutFlow.customerBCoordinates;
    }
}
