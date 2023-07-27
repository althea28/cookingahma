using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of ondeh ondeh dish. Destroys coconut flakes when trashing or serving dish.
*/
public class cookedcoconut : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys coconut flakes when trashign or serving this dish.
    */
    void Update()
    {
       if ((destroyA) && (isOnPlateA())) {
           destroyA = false;
           Destroy (gameObject);
       } else if ((destroyB) && (isOnPlateB())) {
           destroyB = false;
           Destroy (gameObject);
       }
    }

    bool isOnPlateA() {
        return transform.position == gameflow3.plateACoords + 
            gameflow3.cookedOndehCoords + gameflow3.addCoconutCoords;
    }
    bool isOnPlateB() {
        return transform.position == gameflow3.plateBCoords + 
            gameflow3.cookedOndehCoords + gameflow3.addCoconutCoords;
    }

}
