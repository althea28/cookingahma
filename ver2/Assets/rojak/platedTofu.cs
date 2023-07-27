using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Part of rojak dish. Destroys plated tofu when serving customer.
*/

public class platedTofu : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    /* Destroys plated tofu when serving customer.
    */
    void Update()
    {
        if ((destroyA) && (isOnBowlA())) {
            destroyA = false;
            platedSauce.destroyA = true;
            Destroy(gameObject);
        } else if ((destroyB) && (isOnBowlB())) {
            destroyB = false;
            platedSauce.destroyB = true;
            Destroy(gameObject);
        } 

    }
     
    bool isOnBowlA() {
        return transform.position == gameflow2.bowlACoords;
    }
    bool isOnBowlB() {
        return transform.position == gameflow2.bowlBCoords;
    }

}
