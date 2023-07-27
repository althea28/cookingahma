using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Destroys dish req object after a customer is successfully served.
*/
public class toastReq : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;
    public static bool destroyC = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    /* Destroys dish request model
    */
    void Update()
    {
        if ((destroyA) && (transform.position == customerGenerator.customerACoordinates + customerGenerator.addReqCoordinates)) {
            Destroy (gameObject);
            destroyA = false;
        } else if ((destroyB) && (transform.position == customerGenerator.customerBCoordinates + customerGenerator.addReqCoordinates)) {
            Destroy (gameObject);
            destroyB = false;
        } else if ((destroyC) && (transform.position == customerGenerator.customerCCoordinates + customerGenerator.addReqCoordinates)) {
            Destroy (gameObject);
            destroyC = false;
        }
    }
}
