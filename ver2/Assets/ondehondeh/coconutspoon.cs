using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* part of ondeh ondeh dish. Shows visual feedback when coconut flakes bowl is clicked.
*/
public class coconutspoon : MonoBehaviour
{
    public static Vector3 downCoords = new Vector3(2.455f, 4.131f, 1.211f);
    private static Vector3 upCoords = downCoords + new Vector3(0,1,0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /*Changes postiion of coconut flakes spoon depedning on whether coconut flakes bowl is clicked.
    */
    void Update()
    {
        if ((gameflow3.coconutClicked) && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((!gameflow3.coconutClicked) && (transform.position == upCoords)) {
            transform.position = downCoords;
        }

        
    }
}
