using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batterBucketTut : MonoBehaviour
{
    public Transform chweeKuehAObj;
    public Transform chweeKuehBObj;
    public Transform chweeKuehCObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (ckTutFlow.stepCounter == ckTutFlow.stepStart) {
            Instantiate(chweeKuehAObj, ckTutFlow.steamerACoords, chweeKuehAObj.rotation);
            ckTutFlow.stepCounter ++;
        } else if (ckTutFlow.stepCounter == ckTutFlow.stepAddBatterA) {
            Instantiate(chweeKuehBObj, ckTutFlow.steamerBCoords, chweeKuehBObj.rotation);
            ckTutFlow.stepCounter ++;
        } else if (ckTutFlow.stepCounter == ckTutFlow.stepTrashUndercooked) {
            Instantiate(chweeKuehCObj, ckTutFlow.steamerACoords, chweeKuehCObj.rotation);
            ckTutFlow.stepCounter ++;
        }
    }

}
