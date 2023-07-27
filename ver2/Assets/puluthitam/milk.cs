using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of pulut hitam dish. Destroys milk during trashing/serving mechanism.
*/
public class milk : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys milk during trashing/serving mechanism.
    */
    void Update()
    {
        if ((destroyA) && (isOnBowlA())) {
            destroyA = false;
            Destroy(gameObject);
        } else if ((destroyB) && (isOnBowlB())) {
            destroyB = false;
            Destroy(gameObject);
        }
    }

    bool isOnBowlA() {
        return transform.position == gameflow3.bowlACoords + gameflow3.addPulutCoords + gameflow3.addMilkCoords;
    }
    bool isOnBowlB() {
        return transform.position == gameflow3.bowlBCoords + gameflow3.addPulutCoords + gameflow3.addMilkCoords;
    }

}



