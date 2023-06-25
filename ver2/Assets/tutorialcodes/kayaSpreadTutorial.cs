using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayaSpreadTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((tutorialflow.destroyKaya =="y") && 
            (transform.position == tutorialflow.boardACoordinates+tutorialflow.addKayaCoordinates)) 
            {
            Destroy (gameObject);
            tutorialflow.destroyKaya = "n";
        } 
    }
}
