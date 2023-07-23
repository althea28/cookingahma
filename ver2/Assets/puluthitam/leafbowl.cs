using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class leafbowl : MonoBehaviour
{
    public Transform pandanObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (gameflow3.potAStep == 2) {
            Instantiate(pandanObj, gameflow3.potACoords + gameflow3.addPandanCoords, pandanObj.rotation);
            gameflow3.potAStep ++;
        } else if (gameflow3.potBStep == 2) {
            Instantiate(pandanObj, gameflow3.potBCoords + gameflow3.addPandanCoords, pandanObj.rotation);
            gameflow3.potBStep ++;
        }

        //reset
        gameflow3.resetClicks = true;
    }
}
