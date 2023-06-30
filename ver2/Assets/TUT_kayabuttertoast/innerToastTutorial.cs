using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class innerToastTutorial : MonoBehaviour
{
    public static string aHasChanged = "n";
    public static string bHasChanged = "n";

    public Material cookedBreadMat;
    public Material burnedBreadMat;

    // Start is called before the first frame update
    void Start()
    {
        aHasChanged = "n";
        bHasChanged = "n";
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((tutorialflow.changeInnerA == "y") && (aHasChanged == "n") && (transform.position.x == -2.15f))
        {
            aHasChanged = "y";
            changeMatToCooked();
        } else if ((tutorialflow.changeInnerB == "y") && (bHasChanged == "n") && (transform.position.x == -3.94f)) 
        {
            bHasChanged = "y";
            changeMatToCooked();
        }

        if ((tutorialflow.addedButter == "y") && (transform.position.x == -3.94f)) 
        {
            GetComponent<MeshRenderer> ().material = burnedBreadMat;

        }
    }

    void changeMatToCooked() {
        GetComponent<MeshRenderer> ().material = cookedBreadMat;    
        }
}
