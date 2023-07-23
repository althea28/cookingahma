using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class soyasaucebottle : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(1.36f, 3.59f, 1.27f);
    private static Vector3 upCoords = downCoords + new Vector3(0,0.5f,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.soyaSauceClicked) && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((!gameflow.soyaSauceClicked) && (transform.position == upCoords)) {
            transform.position = downCoords;
        }
    }

    void OnMouseDown() {
        gameflow.soyaSauceClicked = true;

        //RESET===
        gameflow.resetClicksToast = true;
        gameflow.plateAClicked = false;
        gameflow.plateBClicked = false;
    }
}
