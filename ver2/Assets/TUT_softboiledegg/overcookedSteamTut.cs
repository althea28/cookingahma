using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overcookedSteamTut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == 13) && (isOnSteamerA())) {
            Destroy (gameObject);
        }
    }

    bool isOnSteamerA() {
        return transform.position == sbeTutFlow.steamerACoords;
    }
}
