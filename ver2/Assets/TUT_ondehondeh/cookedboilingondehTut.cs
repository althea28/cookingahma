using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedboilingondehTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepBoilDoughC)
        {
            Destroy(gameObject);
        }
    }
}
