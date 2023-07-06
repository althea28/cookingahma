using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soyasaucebottleTut : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(1.36f, 3.59f, 1.27f);
    private static Vector3 upCoords = downCoords + new Vector3(0,0.5f,0);

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == 10) && (transform.position == upCoords)) {
            transform.position = downCoords;
            }
        
    }

    void OnMouseDown() {
        if (sbeTutFlow.stepCounter == 8) {
            transform.position = upCoords;
            sbeTutFlow.stepCounter++;
        }
    }
}
