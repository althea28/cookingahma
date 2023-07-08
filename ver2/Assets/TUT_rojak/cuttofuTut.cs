using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuttofuTut : MonoBehaviour
{
    public Transform platedTofuObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (rojakTutFlow.stepCounter == 12) {
            Instantiate(platedTofuObj, rojakTutFlow.bowlACoords, platedTofuObj.rotation);
            Destroy(gameObject);
            rojakTutFlow.stepCounter++;
        }
    }
}
