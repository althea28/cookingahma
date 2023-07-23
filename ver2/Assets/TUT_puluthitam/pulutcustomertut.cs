using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulutcustomertut : MonoBehaviour
{
    public Transform phReqObj;

    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(phReqObj, transform.position + pulutTutFlow.addReqCoordinates, phReqObj.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if ((pulutTutFlow.stepCounter == pulutTutFlow.stepClickCooked) && (transform.position == pulutTutFlow.customerBCoordinates)) {
            Destroy(gameObject);
            pulutTutFlow.stepCounter++;
        }
    }
}
