using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulutSteam : MonoBehaviour
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
        if ((destroyA) && (isOnPotA())) {
            destroyA = false;
            Destroy(gameObject);
        } else if ((destroyB) && (isOnPotB())) {
            destroyB = false;
            Destroy(gameObject);
        }
    }

    bool isOnPotA() {
        return transform.position == gameflow3.potACoords;
    }
    bool isOnPotB() {
        return transform.position == gameflow3.potBCoords;
    }

}


