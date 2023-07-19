using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L8_Initiate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameflow3.initiating) {
           gameflow3.initiating = false;

           gameflow3.plateACoords = new Vector3(4.605f, 3.115f, 3.643f);
           gameflow3.plateBCoords = new Vector3(2.706f, 3.115f, 3.643f);
           gameflow3.steamerACoords = new Vector3(6.55f, 3.636f, 2.11f);
           gameflow3.steamerBCoords = new Vector3(6.55f, 3.636f, 3.774f);

           gameflow3.sugarOnDoughCoords = new Vector3(4.888f, 4.04f, 1.64f);

           coconutspoon.downCoords = new Vector3(2.455f, 4.131f, 1.211f);
           
       }
    }
}
