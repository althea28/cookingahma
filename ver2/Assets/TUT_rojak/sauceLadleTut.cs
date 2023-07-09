using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sauceLadleTut : MonoBehaviour
{
    private Vector3 upCoords = new Vector3(-0.35f, 4.58f, 1.11f);
    private Vector3 downCoords = new Vector3(-0.35f, 3.58f, 1.11f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rojakTutFlow.stepCounter == 14) {
           transform.position = upCoords;
       } else if (transform.position == upCoords) {
           transform.position = downCoords;
    }
    }
}
