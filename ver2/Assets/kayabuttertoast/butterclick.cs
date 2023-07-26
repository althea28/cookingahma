using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class butterclick : MonoBehaviour
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
        gameflow.placeButter = true;

        //RESET===
        gameflow.resetClicksEggs = true;
        gameflow.toastAIsClicked = false;
        gameflow.toastBIsClicked = false;
        gameflow.placeKaya = false;
    }
}
