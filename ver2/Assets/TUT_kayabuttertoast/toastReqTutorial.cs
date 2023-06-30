using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastReqTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((tutorialflow.destroyReq == "y") && 
            (transform.position == tutorialflow.customerBCoordinates+tutorialflow.addReqCoordinates)) {
            Destroy (gameObject);
            tutorialflow.destroyReq = "n";
        }
        
    }
}
