using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayabottleclick : MonoBehaviour
{
    
    public Transform kayaObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        gameflow.placeKaya = "y";
        //Instantiate(kayaObj, new Vector3(-1.8f, 3.2f, 3.35f), kayaObj.rotation);
    }
}
