using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterspreadclick : MonoBehaviour
{

    public static string destroyButterA = "n";
    public static string destroyButterB = "n";

    // Start is called before the first frame update
    void Start()
    {
        
    }

   // Update is called once per frame
    void Update()
    {
        if ((destroyButterA == "y") && (transform.position == gameflow.boardACoordinates + gameflow.addButterCoordinates)) {
            Destroy (gameObject);
            destroyButterA = "n";
        }
        if ((destroyButterB == "y") && (transform.position == gameflow.boardBCoordinates + gameflow.addButterCoordinates)) {
            Destroy (gameObject);
            destroyButterB = "n";
        }
    }

}
