using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastReq : MonoBehaviour
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
        if ((destroyA == "y") && (transform.position == gameflow.customerACoordinates + gameflow.addReqCoordinates)) {
            Destroy (gameObject);
            destroyA = "n";
        } else if ((destroyB == "y") && (transform.position == gameflow.customerBCoordinates + gameflow.addReqCoordinates)) {
            Destroy (gameObject);
            destroyB = "n";
        } else if ((destroyC == "y") && (transform.position == gameflow.customerCCoordinates + gameflow.addReqCoordinates)) {
            Destroy (gameObject);
            destroyC = "n";
        }
    }
}
