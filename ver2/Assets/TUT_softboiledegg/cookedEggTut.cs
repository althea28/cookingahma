using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedEggTut : MonoBehaviour
{
    public Transform soyasauceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepServeCustomer) && (isOnPlateA())) {
            Destroy (gameObject);
        }
        
    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == sbeTutFlow.stepClickSoya) && (isOnPlateA())) {
            Instantiate(soyasauceObj, 
                transform.position + sbeTutFlow.addSoyaSauceCoords, soyasauceObj.rotation);
            sbeTutFlow.stepCounter ++;
        } else if ((sbeTutFlow.stepCounter == sbeTutFlow.stepAddSoya) && (isOnPlateA())) {
            sbeTutFlow.stepCounter ++;
        }    }

    bool isOnPlateA() {
        return transform.position == sbeTutFlow.plateACoords + sbeTutFlow.addCookedEggsCoords;
    }
}
