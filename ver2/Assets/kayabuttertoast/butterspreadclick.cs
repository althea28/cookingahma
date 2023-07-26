using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class butterspreadclick : MonoBehaviour
{

    public static bool destroyButterA = false;
    public static bool destroyButterB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   // Update is called once per frame
    void Update()
    {
        if ((destroyButterA) && (transform.position == gameflow.boardACoordinates + gameflow.addButterCoordinates)) {
            Destroy (gameObject);
            destroyButterA = false;
        }
        if ((destroyButterB) && (transform.position == gameflow.boardBCoordinates + gameflow.addButterCoordinates)) {
            Destroy (gameObject);
            destroyButterB = false;
        }
    }

}
