using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayaclick : MonoBehaviour
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
        Instantiate(kayaObj, new Vector3(-1.8f,3.2f,3.4f), kayaObj.rotation);
    }
}
