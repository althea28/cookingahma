using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterclick : MonoBehaviour
{
    public Transform butterObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        Instantiate(butterObj, new Vector3(-1.8f,3.3f,3.3f), butterObj.rotation);
    }
}
