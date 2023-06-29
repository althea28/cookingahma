using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggcartonTut : MonoBehaviour
{
    public Transform eggAObj;
    public Transform eggBObj;
    public Transform eggCObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (sbeTutFlow.stepCounter == 1) {
            Instantiate(eggAObj, sbeTutFlow.steamerACoords, eggAObj.rotation);
            sbeTutFlow.stepCounter ++;
        } else if (sbeTutFlow.stepCounter == 2) {
            Instantiate(eggBObj, sbeTutFlow.steamerBCoords, eggBObj.rotation);
            sbeTutFlow.stepCounter ++;
        } else if (sbeTutFlow.stepCounter == 6) {
            Instantiate(eggCObj, sbeTutFlow.steamerACoords, eggCObj.rotation);
            sbeTutFlow.stepCounter ++;
        }
    }

}
