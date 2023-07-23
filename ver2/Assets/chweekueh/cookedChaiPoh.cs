using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class cookedChaiPoh : MonoBehaviour
{
    public static bool trashChaiPohA = false;
    public static bool trashChaiPohB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((trashChaiPohA) && (isOnPlateA())) {
            trashChaiPohA = false;
            Destroy (gameObject);
        } else if ((trashChaiPohB) && (isOnPlateB())) {
            trashChaiPohB = false;
            Destroy (gameObject);
        } 
        
    }

    bool isOnPlateA() {
        return transform.position == gameflow2.plateACoords + gameflow2.addCookedCKCoords + gameflow2.addCookedCP;
    }

    bool isOnPlateB() {
        return transform.position == gameflow2.plateBCoords + gameflow2.addCookedCKCoords + gameflow2.addCookedCP;
    }

}
