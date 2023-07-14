using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarcube : MonoBehaviour
{
    public static bool destroy  = false;
    // Start is called before the first frame update
    void Start()
    {
        destroy = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroy) && (isOnDough())) {
            destroy = false;
            Destroy (gameObject);
        }
        
    }

    bool isOnDough() {
        return transform.position == gameflow3.sugarOnDoughCoords;
    }
}
