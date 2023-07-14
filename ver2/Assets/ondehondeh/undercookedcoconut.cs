using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class undercookedcoconut : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyA) && (isOnPlateA())) {
           destroyA = false;
           Destroy (gameObject);
       } else if ((destroyB) && (isOnPlateB())) {
           destroyB = false;
           Destroy (gameObject);
       }
    }
    
    bool isOnPlateA() {
        return transform.position == gameflow3.plateACoords + 
            gameflow3.undercookedOndehCoords + gameflow3.addUndercookedCoconutCoords;
    }
    bool isOnPlateB() {
        return transform.position == gameflow3.plateBCoords + 
            gameflow3.undercookedOndehCoords + gameflow3.addUndercookedCoconutCoords;
    }

}
