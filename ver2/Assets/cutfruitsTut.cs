using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutfruitsTut : MonoBehaviour
{
    public Transform platedFruitsObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (rojakTutFlow.stepCounter == 4) {
            Instantiate(platedFruitsObj, rojakTutFlow.bowlACoords, platedFruitsObj.rotation);
            Destroy(gameObject);
            rojakTutFlow.stepCounter++;
        }
    }
}
