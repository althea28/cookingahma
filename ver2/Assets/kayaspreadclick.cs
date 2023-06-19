using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayaspreadclick : MonoBehaviour
{
    
    public static string destroyKayaA = "n";
    public static string destroyKayaB = "n";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyKayaA == "y") && (transform.position == gameflow.boardACoordinates + gameflow.addKayaCoordinates)) {
            Destroy (gameObject);
            destroyKayaA = "n";
        }
        if ((destroyKayaB == "y") && (transform.position == gameflow.boardBCoordinates + gameflow.addKayaCoordinates)) {
            Destroy (gameObject);
            destroyKayaB = "n";
        }

        /* ============
        if (gameflow.destroyKaya == "y") {
            Debug.Log("shift kaya");
            GetComponent<Transform> ().position = new Vector3(3,3,10);
        }
        gameflow.destroyKaya = "n";
        */ //===========
    }

    

}
