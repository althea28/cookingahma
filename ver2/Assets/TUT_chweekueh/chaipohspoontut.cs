using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaipohspoontut : MonoBehaviour
{
    
    private Vector3 downCoords = new Vector3 (-1.05f, 3.784f, 1.33f);
    private Vector3 upCoords = new Vector3 (-1.05f, 4.784f, 1.33f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ckTutFlow.stepCounter == 9) && (transform.position == downCoords)) {
            transform.position = upCoords;
        }
        if ((ckTutFlow.stepCounter == 10) && (transform.position == upCoords)) {
            transform.position = downCoords;
        }
    }
}
