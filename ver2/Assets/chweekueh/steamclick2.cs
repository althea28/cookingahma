using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class steamclick2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow2.destroySteamA == "y") && (transform.position == gameflow2.steamerACoords)) {
           Destroy (gameObject);
           gameflow2.destroySteamA = "n";
       } else if ((gameflow2.destroySteamB == "y") && (transform.position == gameflow2.steamerBCoords)) {
           Destroy (gameObject);
           gameflow2.destroySteamB = "n";
       }

    }
}
