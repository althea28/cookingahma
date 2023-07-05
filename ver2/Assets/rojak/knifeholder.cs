using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeholder : MonoBehaviour
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
        gameflow2.knifeClicked = true;

        //RESET
        gameflow2.resetClicksChweeKueh = true;

        gameflow2.sauceClicked = false;
        gameflow2.boardAClicked = false;
        gameflow2.boardBClicked = false;
        gameflow2.bowlAClicked = false;
        gameflow2.bowlBClicked = false;

    }
}
