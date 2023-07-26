using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class toastInner : MonoBehaviour
{
    
    public Material cookedBreadMat; //
    public Material burnedBreadMat;

    public static bool changedToCookedA = false;
    public static bool changedToCookedB = false;
    public static bool changedToBurntA = false;
    public static bool changedToBurntB = false;


    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if ((!changedToCookedA) && (toastclick.toastAIsCooked) && 
            (transform.position.x == gameflow.grillACoordinates.x)) {
            GetComponent<MeshRenderer> ().material = cookedBreadMat;
            changedToCookedA = true;
        } else if ((!changedToCookedB) && (toastclick.toastBIsCooked) && 
        (transform.position.x == gameflow.grillBCoordinates.x)) {
            GetComponent<MeshRenderer> ().material = cookedBreadMat;
            changedToCookedB = true;
        }
        
        if ((!changedToBurntA) && (toastclick.toastAIsBurnt) && 
            (transform.position.x == gameflow.grillACoordinates.x)) {
            GetComponent<MeshRenderer> ().material = burnedBreadMat;
            changedToBurntA = true;
        } else if ((!changedToBurntB) && (toastclick.toastBIsBurnt) && 
            (transform.position.x == gameflow.grillBCoordinates.x)) {
            GetComponent<MeshRenderer> ().material = burnedBreadMat;
            changedToBurntB = true;
        }

    }

    public static void resetA() {
        changedToCookedA = false;
        changedToBurntA = false;
    }

    public static void resetB() {
        changedToCookedB = false;
        changedToBurntB = false;
    }
}
