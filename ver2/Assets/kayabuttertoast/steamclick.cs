using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class steamclick : MonoBehaviour
{
    //private float grillAXCoordinates = -2.15f;
    //private float grillBXCoordinates = -3.94f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.destroySteamA) && (transform.position == gameflow.grillACoordinates)) {
           Destroy (gameObject);
           gameflow.destroySteamA = false;
       } else if ((gameflow.destroySteamB) && (transform.position == gameflow.grillBCoordinates)) {
           Destroy (gameObject);
           gameflow.destroySteamB = false;
       }

    }
}
