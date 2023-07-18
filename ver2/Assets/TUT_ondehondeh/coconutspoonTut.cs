using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconutspoonTut : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(1.055f, 4.131f, 1.211f);
    private static Vector3 upCoords = downCoords + new Vector3(0,1,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((ondehTutFlow.stepCounter == 15) && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((ondehTutFlow.stepCounter == 16) && (transform.position == upCoords)) {
            transform.position = downCoords;
        }
    }
}
