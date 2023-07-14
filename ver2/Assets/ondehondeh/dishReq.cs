using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dishReq : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;
    public static bool destroyC = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyA) && (transform.position == gameflow3.customerACoordinates + gameflow3.addReqCoordinates)) {
            Destroy (gameObject);
            destroyA = false;
        } else if ((destroyB) && (transform.position == gameflow3.customerBCoordinates + gameflow3.addReqCoordinates)) {
            Destroy (gameObject);
            destroyB = false;
        } else if ((destroyC) && (transform.position == gameflow3.customerCCoordinates + gameflow3.addReqCoordinates)) {
            Destroy (gameObject);
            destroyC = false;
        }
    }
}

