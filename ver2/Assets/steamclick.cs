using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamclick : MonoBehaviour
{
    private float grillAXCoordinates = -2.15f;
    private float grillBXCoordinates = -3.94f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.destroySteamA == "y") && (transform.position.x == grillAXCoordinates)) {
           Destroy (gameObject);
           gameflow.destroySteamA = "n";
       } else if ((gameflow.destroySteamB == "y") && (transform.position.x == grillBXCoordinates)) {
           Destroy (gameObject);
           gameflow.destroySteamB = "n";
       }

    }
}
