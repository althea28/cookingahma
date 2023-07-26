using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class kayaspoon : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(0.276f, 4.473f, 1.559f);
    private static Vector3 upCoords = downCoords + new Vector3(-0.2f,1,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.placeKaya) && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((!gameflow.placeKaya) && (transform.position == upCoords)) {
            transform.position = downCoords;
        }
        
    }
}
