using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soyasaucebottle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        gameflow.soyaSauceClicked = true;

        //RESET===
        gameflow.resetClicksToast = true;
        gameflow.plateAClicked = false;
        gameflow.plateBClicked = false;
    }
}
