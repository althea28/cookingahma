using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Part of chwee kueh dish. Provides visual feedback when chai poh bowl has been clicked
*/
public class cpspoon : MonoBehaviour
{
    private Vector3 downCoords = gameflow2.cpSpoonCoords;
    private Vector3 upCoords = gameflow2.cpSpoonCoords + new Vector3(0,1,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*Raises and lowers spoon when chai poh bowl has been clicked.
    */
    void Update()
    {
       if (downCoords != gameflow2.cpSpoonCoords) { //initiating bug. dont delete
           downCoords = gameflow2.cpSpoonCoords;
           upCoords = downCoords + new Vector3(0,1,0);
       }

       if ((gameflow2.chaiPohClicked) && (transform.position == downCoords)) {
           transform.position = upCoords;
       } else if ((!gameflow2.chaiPohClicked) && (transform.position == upCoords)) {
           transform.position = downCoords;
       } 
    }
}
