using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platedVege : MonoBehaviour
{
    public static bool destroyA = false;
    public static bool destroyB = false;

    // Start is called before the first frame update
    void Start()
    {
        destroyA = false;
        destroyB = false;
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((destroyA) && (isOnBowlA())) {
            destroyA = false;
            platedTofu.destroyA = true;
            Destroy(gameObject);
        } else if ((destroyB) && (isOnBowlB())) {
            destroyB = false;
            platedTofu.destroyB = true;
            Destroy(gameObject);
        } 
 
    }
    
    bool isOnBowlA() {
        return transform.position == gameflow2.bowlACoords;
    }
    bool isOnBowlB() {
        return transform.position == gameflow2.bowlBCoords;
    }

}
