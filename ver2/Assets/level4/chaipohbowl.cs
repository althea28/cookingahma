using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaipohbowl : MonoBehaviour
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
        gameflow2.chaiPohClicked = true;

        //RESET===
        gameflow2.resetClicksChweeKueh = true;
        gameflow2.plateAClicked = false;
        gameflow2.plateBClicked = false;
    }
}
