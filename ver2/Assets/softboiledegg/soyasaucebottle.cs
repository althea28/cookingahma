using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of soft-boiled egg dish. Supports:
 * (i) Adding soya sauce to egg
 * (ii) Provides visual feedback when soya sauce bottle is clicked
*/
public class soyasaucebottle : MonoBehaviour
{
    private static Vector3 downCoords = new Vector3(1.36f, 3.59f, 1.27f);
    private static Vector3 upCoords = downCoords + new Vector3(0,0.5f,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Changes coordinates of bottle after it has been clicked.
    */
    void Update()
    {
        if ((gameflow.soyaSauceClicked) && (transform.position == downCoords)) {
            transform.position = upCoords;
        } else if ((!gameflow.soyaSauceClicked) && (transform.position == upCoords)) {
            transform.position = downCoords;
        }
    }

    /* Indicates in gameflow when soya sauce bottle is clicked. Support addition of soya sauce to eggs.
    */
    void OnMouseDown() {
        gameflow.soyaSauceClicked = true;

        //RESET===
        gameflow.resetClicksToast = true;
        gameflow.plateAClicked = false;
        gameflow.plateBClicked = false;
    }
}
