using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamtutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((tutorialflow.destroySteamA == "y") && (transform.position == tutorialflow.grillACoordinates)) {
            Destroy (gameObject);
            tutorialflow.destroySteamA = "n";
        }
        
    }
}
