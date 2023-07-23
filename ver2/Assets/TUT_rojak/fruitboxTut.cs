using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitboxTut : MonoBehaviour
{
    public Transform precutFruitsObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepStart) {
            Instantiate(precutFruitsObj, rojakTutFlow.boardACoords + rojakTutFlow.addFruitsBoardCoords, precutFruitsObj.rotation);
            rojakTutFlow.stepCounter ++;
        }
    }

}
