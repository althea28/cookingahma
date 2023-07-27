using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of chwee kueh dish. Destroys burnt layer when moving chwee kueh from steamer to plate.
*/
public class burntLayer : MonoBehaviour
{

    public static bool destroyA = false;
    public static bool destroyB = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /* Destroys burnt layer when moving burnt chwee kueh from steamer to dish.
    */
    void Update()
    {
        if ((destroyA) && (isOnA())) {
            Destroy(gameObject);
            destroyA = false;
        } else if ((destroyB) && (isOnB())) {
            Destroy(gameObject);
            destroyB = false;
        }
        
    }

    bool isOnA() {
        return transform.position == gameflow2.steamerACoords + gameflow2.burntLayerCoords;
    } 
    bool isOnB() {
        return transform.position == gameflow2.steamerBCoords + gameflow2.burntLayerCoords;
    }
}
