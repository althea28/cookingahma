using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarcubeTut2 : MonoBehaviour
{
    public static bool destroy  = false;
    // Start is called before the first frame update
    void Start()
    {
        destroy = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (destroy) {
            Destroy (gameObject);
            destroy = false;   
        }*/
        if (ondehTutFlow.stepCounter == ondehTutFlow.stepBoilDoughB) {
            Destroy (gameObject);
        }
    }

}
