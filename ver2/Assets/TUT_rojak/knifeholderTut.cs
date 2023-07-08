using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeholderTut : MonoBehaviour
{
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
        if (rojakTutFlow.stepCounter == 2 || rojakTutFlow.stepCounter == 6 || rojakTutFlow.stepCounter == 10) {
            Debug.Log("here");
            knifeObj.transform.position = upCoords;
            rojakTutFlow.stepCounter++;
        }
    }
}
