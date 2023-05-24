using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastclick : MonoBehaviour
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
        Instantiate(toastObj, new Vector3(-1.8f,3,3.3f), toastObj.rotation);
    }
}
