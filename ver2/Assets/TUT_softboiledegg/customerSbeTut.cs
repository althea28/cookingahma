using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerSbeTut : MonoBehaviour
{
    public Transform eggReqObj;

    // Start is called before the first frame update
    void Start()
    {
       Instantiate(eggReqObj, transform.position + sbeTutFlow.addReqCoordinates, eggReqObj.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == 11) && (isOnCusBCoords())) {
            sbeTutFlow.stepCounter ++;
            Destroy (gameObject);
        }
    }

    bool isOnCusBCoords() {
        return transform.position == sbeTutFlow.customerBCoordinates;
    }
}
