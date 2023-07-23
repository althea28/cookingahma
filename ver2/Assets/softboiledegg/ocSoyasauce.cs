using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class ocSoyasauce : MonoBehaviour
{
    public static bool trashSoyaA = false;
    public static bool trashSoyaB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        return transform.position == gameflow.plateACoords + gameflow.addOvercookedEggsCoords + 
            gameflow.addOCSoyaSauceCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow.plateBCoords + gameflow.addOvercookedEggsCoords + 
            gameflow.addOCSoyaSauceCoords;
    }


}
