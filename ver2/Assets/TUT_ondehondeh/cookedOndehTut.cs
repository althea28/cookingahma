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

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ondehTutFlow.stepCounter == 15) 
        {
            Instantiate(coconutObj, transform.position + ondehTutFlow.addCoconutCoords, coconutObj.rotation);
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == 16) {
            ondehTutFlow.stepCounter++;
        } else if (ondehTutFlow.stepCounter == 17) {
            Destroy (gameObject);
        }
    }
}
