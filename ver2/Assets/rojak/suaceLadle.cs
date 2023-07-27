using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Part of rojak dish. Provides visual feedback when rojak sauce is clicked.
*/
public class suaceLadle : MonoBehaviour
{
    private Vector3 upCoords = new Vector3(-0.35f, 4.58f, 1.11f);
    private Vector3 downCoords = new Vector3(-0.35f, 3.58f, 1.11f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*Changes position of sauce ladle depending on when sauce is clicked or not
    */
    void Update()
    {
        if ((gameflow2.sauceClicked) && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((!gameflow2.sauceClicked) && (transform.position == upCoords)) {
            transform.position = downCoords;
        } 
        
    }
}
