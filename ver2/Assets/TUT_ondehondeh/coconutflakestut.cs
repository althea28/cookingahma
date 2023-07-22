using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconutflakestut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        if ((ondehTutFlow.stepCounter == 18) && (transform.position == 
                ondehTutFlow.plateACoords + ondehTutFlow.cookedOndehCoords + ondehTutFlow.addCoconutCoords))  {
            Destroy(gameObject);
        }
    }
}
