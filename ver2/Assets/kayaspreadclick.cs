using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayaspreadclick : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameflow.destroyKaya == "y") {
            Debug.Log("shift kaya");
            GetComponent<Transform> ().position = new Vector3(3,3,10);
        }
        gameflow.destroyKaya = "n";
    }

}
