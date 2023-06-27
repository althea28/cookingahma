using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggSteam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((eggs.trigDestroyCookedSteamA) && (isOnSteamerA())) {
            Destroy (gameObject);
            eggs.trigDestroyCookedSteamA = false;
        }

        if ((eggs.trigDestroyCookedSteamB) && (isOnSteamerB())) {
            Destroy (gameObject);
            eggs.trigDestroyCookedSteamB = false;
        }

        
    }

    bool isOnSteamerA() {
        return transform.position == gameflow.steamerACoords;
    }

    bool isOnSteamerB() {
        return transform.position == gameflow.steamerBCoords;
    }

}
