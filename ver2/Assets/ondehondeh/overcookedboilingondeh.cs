using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class overcookedboilingondeh : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyA) && (isOnSteamerA())) {
            destroyA = false;
            Destroy (gameObject);
        }
        if ((destroyB) && (isOnSteamerB())) {
            destroyB = false;
            Destroy (gameObject);
        }

        
    }

    bool isOnSteamerA() {
        return transform.position == gameflow3.steamerACoords + gameflow3.addBoilingOndehCoords;
    }
    bool isOnSteamerB() {
        return transform.position == gameflow3.steamerBCoords + gameflow3.addBoilingOndehCoords;
    }

}
