using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarcubeTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepBoilDoughA) {
            Destroy (gameObject);
        }
    }

}
