using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarBowlTut : MonoBehaviour
{
    public Transform sugarCubeObj;
    public Transform sugarCube2Obj;
    public Transform sugarCube3Obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ondehTutFlow.stepCounter == 1) {
            Instantiate(sugarCubeObj, ondehTutFlow.sugarOnDoughCoords, sugarCubeObj.rotation);
            ondehTutFlow.stepCounter ++;
        }
        if (ondehTutFlow.stepCounter == 3) {
            Instantiate(sugarCube2Obj, ondehTutFlow.sugarOnDoughCoords, sugarCube2Obj.rotation);
            ondehTutFlow.stepCounter ++;
        }
        if (ondehTutFlow.stepCounter == 8) {
            Instantiate(sugarCube3Obj, ondehTutFlow.sugarOnDoughCoords, sugarCube3Obj.rotation);
            ondehTutFlow.stepCounter ++;
        }
    }
}
