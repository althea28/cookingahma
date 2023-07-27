using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* class butterspreadclick destroys butter spread on toast. Called when trashing or serving kaya butter toast.
*/

public class butterspreadclick : MonoBehaviour
{

    public static bool destroyButterA = false;
    public static bool destroyButterB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   // Update is called once per frame
   /* Destroys butter spread when needed.
   */
    void Update()
    {
        if ((destroyButterA) && (transform.position == gameflow.boardACoordinates + gameflow.addButterCoordinates)) {
            Destroy (gameObject);
            destroyButterA = false;
        }
        if ((destroyButterB) && (transform.position == gameflow.boardBCoordinates + gameflow.addButterCoordinates)) {
            Destroy (gameObject);
            destroyButterB = false;
        }
    }

}
