using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of soft boiled egg dish. Supports trashing or serving mechanism of dish.
*/
public class soyasauce : MonoBehaviour
{
    public static bool trashSoyaA = false;
    public static bool trashSoyaB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys soya sauce object when trashing or serving this dish.
    */
    void Update()
    {
        if ((trashSoyaA) && (isOnPlateA())) {
            trashSoyaA = false;
            Destroy (gameObject);
        } else if ((trashSoyaB) && (isOnPlateB())) {
            trashSoyaB = false;
            Destroy (gameObject);
        } 
        
    }

    bool isOnPlateA() {
        return transform.position == gameflow.plateACoords + gameflow.addUndercookedEggsCoords + 
            gameflow.addSoyaSauceCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow.plateBCoords + gameflow.addUndercookedEggsCoords + 
            gameflow.addSoyaSauceCoords;
    }

}
