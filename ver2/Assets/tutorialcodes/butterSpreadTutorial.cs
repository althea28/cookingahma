using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterSpreadTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((tutorialflow.destroyButter =="y") && 
            (transform.position == tutorialflow.boardACoordinates+tutorialflow.addButterCoordinates)) 
            {
            Destroy (gameObject);
            tutorialflow.destroyButter = "n";

        }
 
    }
}
