using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehReqTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepServeCustomer)
        {
            Destroy(gameObject);
        }
    }
}
