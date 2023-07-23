using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class knife : MonoBehaviour
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
       if ((gameflow2.knifeClicked) && (transform.position == downCoords)) {
           transform.position = upCoords;
       } else if ((!gameflow2.knifeClicked) && (transform.position == upCoords)) {
           transform.position = downCoords;
       }
    }
}
