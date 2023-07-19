using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkladle : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(0.21f, 3.99f, 1.08f);
    private static Vector3 upCoords = downCoords + new Vector3(0,1,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((gameflow3.milkIsClicked) && (transform.position == downCoords)) {
           transform.position = upCoords;
       } else if ((!gameflow3.milkIsClicked) && (transform.position == upCoords)) {
           transform.position = downCoords;
       }
    }
}
