using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** dishOne class is attached to GAMEMASTER in levels 1, 4 and 7
 * sets the number of possible dishes that can be served in every level to be 1
*/
public class dishOne : MonoBehaviour
{
    private int numOfDishes = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.initiating) || (gameflow2.initiating) ||(gameflow3.initiating)) {
            
            customerGenerator.numOfDishes = numOfDishes;
            
            gameflow.initiating = false;
            gameflow2.initiating = false;
            gameflow3.initiating = false;
        }
        
    }
}
