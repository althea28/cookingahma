using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlTut : MonoBehaviour
{
    public Transform sauceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
    }
 
    void OnMouseDown() {
        if (rojakTutFlow.stepCounter == rojakTutFlow.stepClickSauce) { //adding sauce
            Instantiate(sauceObj, transform.position, sauceObj.rotation);
            rojakTutFlow.stepCounter++;
        } else if (rojakTutFlow.stepCounter == rojakTutFlow.stepAddSauce) {
            rojakTutFlow.stepCounter++;
        }
    }
}
