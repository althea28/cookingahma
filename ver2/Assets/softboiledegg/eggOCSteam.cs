using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggOCSteam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((eggs.trigDestroyOvercookedSteamA) && (isOnSteamerA())) {
            Destroy (gameObject);
            eggs.trigDestroyOvercookedSteamA = false;
        }

        if ((eggs.trigDestroyOvercookedSteamB) && (isOnSteamerB())) {
            Destroy (gameObject);
            eggs.trigDestroyOvercookedSteamB = false;
        }

        
    }

    bool isOnSteamerA() {
        return transform.position == gameflow.steamerACoords;
    }

    bool isOnSteamerB() {
        return transform.position == gameflow.steamerBCoords;
    }
 
}
