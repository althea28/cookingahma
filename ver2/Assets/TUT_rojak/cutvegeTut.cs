using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutvegeTut : MonoBehaviour
{
    public Transform platedVegObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (rojakTutFlow.stepCounter == 8) {
            Instantiate(platedVegObj, rojakTutFlow.bowlACoords, platedVegObj.rotation);
            Destroy(gameObject);
            rojakTutFlow.stepCounter++;
        }
    }
}
