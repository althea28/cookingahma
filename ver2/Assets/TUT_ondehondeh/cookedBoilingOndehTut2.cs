using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedBoilingOndehTut2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ondehTutFlow.stepCounter == 14)
        {
            Destroy(gameObject);
        }
    }
}
