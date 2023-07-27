using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/*Part of pulut hitam dish. Destroys cooked cooking pulut hitam when moving from pot to bowl
*/

public class cookedCookingPulut : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys cooked cooking pulut hitam when moving from pot to bowl
    */
    void Update()
    {
        if ((destroyA) && (isOnPotA())) {
            destroyA = false;
            Destroy(gameObject);
        } else if ((destroyB) && (isOnPotB())) {
            destroyB = false;
            Destroy(gameObject);
        }
    }

    bool isOnPotA() {
        return transform.position == gameflow3.potACoords + gameflow3.addRiceCoords;
    }
    bool isOnPotB() {
        return transform.position == gameflow3.potBCoords + gameflow3.addRiceCoords;
    }

}

