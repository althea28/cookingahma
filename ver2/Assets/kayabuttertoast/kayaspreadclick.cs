using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class kayaspreadclick : MonoBehaviour
{
    
    public static bool destroyKayaA = false;
    public static bool destroyKayaB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyKayaA) && (transform.position == gameflow.boardACoordinates + gameflow.addKayaCoordinates)) {
            Destroy (gameObject);
            destroyKayaA = false;
        }
        if ((destroyKayaB) && (transform.position == gameflow.boardBCoordinates + gameflow.addKayaCoordinates)) {
            Destroy (gameObject);
            destroyKayaB = false;
        }

    }

    

}
