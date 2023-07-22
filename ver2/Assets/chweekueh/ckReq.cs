using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ckReq : MonoBehaviour
{
    public static string destroyA = "n";
    public static string destroyB = "n";
    public static string destroyC = "n";

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyA == "y") && (transform.position == gameflow2.customerACoordinates + gameflow2.addReqCoordinates)) {
            Destroy (gameObject);
            destroyA = "n";
        } else if ((destroyB == "y") && (transform.position == gameflow2.customerBCoordinates + gameflow2.addReqCoordinates)) {
            Destroy (gameObject);
            destroyB = "n";
        } else if ((destroyC == "y") && (transform.position == gameflow2.customerCCoordinates + gameflow2.addReqCoordinates)) {
            Destroy (gameObject);
            destroyC = "n";
        }
    }
}
