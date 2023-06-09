using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastInner : MonoBehaviour
{
    
    public Material cookedBreadMat; //
    public Material burnedBreadMat;

    private static string changedToCookedA = "n";
    private static string changedToCookedB = "n";
    private static string changedToBurntA = "n";
    private static string changedToBurntB = "n";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((changedToCookedA == "n") && (toastclick.toastAIsCooked == "y") && (transform.position.x == -2.15f)) {
            GetComponent<MeshRenderer> ().material = cookedBreadMat;
            changedToCookedA = "y";
        } else if ((changedToCookedB == "n") && (toastclick.toastBIsCooked == "y") && (transform.position.x == -3.94f)) {
            GetComponent<MeshRenderer> ().material = cookedBreadMat;
            changedToCookedB = "y";
        }
        
        if ((changedToBurntA == "n") && (toastclick.toastAIsBurnt == "y") && (transform.position.x == -2.15f)) {
            GetComponent<MeshRenderer> ().material = burnedBreadMat;
            changedToBurntA = "y";
        } else if ((changedToBurntB == "n") && (toastclick.toastBIsBurnt == "y") && (transform.position.x == -3.94f)) {
            GetComponent<MeshRenderer> ().material = burnedBreadMat;
            changedToBurntB = "y";
        }

    }

    public static void resetA() {
        changedToCookedA = "n";
        changedToBurntA = "n";
    }

    public static void resetB() {
        changedToCookedB = "n";
        changedToBurntB = "n";
    }
}
