using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class butterknife : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(-2.054f, 3.479f, 1.607f);
    private static Vector3 upCoords = downCoords + new Vector3(0,1,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.placeButter == "y") && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((gameflow.placeButter == "n") && (transform.position == upCoords)) {
            transform.position = downCoords;
        }
        
    }
}
