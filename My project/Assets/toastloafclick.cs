using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastloafclick : MonoBehaviour
{
    public Transform toastObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (gameflow.toastOnGrillA == "n") {
            Instantiate(toastObj, new Vector3(-2.15f,3.072f,3.3f), toastObj.rotation);
            gameflow.toastOnGrillA = "y";
        } else if (gameflow.toastOnGrillB == "n") {
            Instantiate(toastObj, new Vector3(-3.94f,3.072f,3.3f), toastObj.rotation);
            gameflow.toastOnGrillB = "y";
        }
    }
}
