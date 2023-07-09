using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeTut : MonoBehaviour
{
    private Vector3 downCoords = new Vector3(-3,4,2.686f);
    private Vector3 upCoords = new Vector3(-3,5,2.686f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (rojakTutFlow.stepCounter == 3 || rojakTutFlow.stepCounter == 7 || rojakTutFlow.stepCounter == 11) {
           transform.position = upCoords;
       } else if (transform.position == upCoords) {
           transform.position = downCoords;
       }
    }
}
