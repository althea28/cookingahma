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
        if (rojakTutFlow.stepCounter == 14) { //adding sauce
            Instantiate(sauceObj, transform.position, sauceObj.rotation);
            rojakTutFlow.stepCounter++;
        } else if (rojakTutFlow.stepCounter == 15) {
            rojakTutFlow.stepCounter++;
        }
    }
}
