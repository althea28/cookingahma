using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpspoon : MonoBehaviour
{
    private Vector3 downCoords = new Vector3 (1.194f, 3.784f, 1.07f);
    private Vector3 upCoords = new Vector3 (1.194f, 4.784f, 1.07f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((gameflow2.chaiPohClicked) && (transform.position == downCoords)) {
           transform.position = upCoords;
       } else if ((!gameflow2.chaiPohClicked) && (transform.position == upCoords)) {
           transform.position = downCoords;
       } 
    }
}
