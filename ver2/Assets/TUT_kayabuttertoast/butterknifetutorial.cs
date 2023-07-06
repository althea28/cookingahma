using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterknifetutorial : MonoBehaviour
{
    public static bool moveUp = false;
    public static bool moveDown = false; 
    private Vector3 moveCoords = new Vector3(0,1,0);

    // Start is called before the first frame update
    void Start()
    {
        moveUp = false;
        moveDown = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp) {
            transform.position += moveCoords;
            moveUp = false;
        } else if (moveDown) {
            transform.position -= moveCoords;
            moveDown = false;
        }
        
    }
}
