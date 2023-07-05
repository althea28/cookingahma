using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platedFruits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow2.serveRojakA) && (isOnBowlA())) {
            gameflow2.serveRojakA = false;
            platedVege.destroyA = true;
            Destroy(gameObject);
        } else if ((gameflow2.serveRojakB) && (isOnBowlB())) {
            gameflow2.serveRojakB = false;
            platedVege.destroyB = true;
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
