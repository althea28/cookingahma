using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class precutfruitsTut : MonoBehaviour
{
    public Transform cutFruitsObj;
    public Transform knifeObj;
    private Vector3 downCoords = new Vector3(-3,4,2.686f);
    private Vector3 upCoords = new Vector3(-3,5,2.686f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepClickKnifeA) { //to cut fruits
            Instantiate(cutFruitsObj, rojakTutFlow.boardACoords + rojakTutFlow.addCutFruitsBoardCoords, cutFruitsObj.rotation);
            Destroy(gameObject);
            rojakTutFlow.stepCounter++;
                }
            
            //reset

    }
}
