using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggATUT : MonoBehaviour
{
    public Transform undercookedEggObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        if ((sbeTutFlow.stepCounter == 3) && (isOnSteamerA())) {
            Instantiate(undercookedEggObj, 
                sbeTutFlow.plateACoords + sbeTutFlow.addUndercookedEggsCoords, 
                undercookedEggObj.rotation);
            Destroy (gameObject);
            sbeTutFlow.stepCounter ++;
        }
    }

    bool isOnSteamerA() {
        return transform.position == sbeTutFlow.steamerACoords;
    }
}
