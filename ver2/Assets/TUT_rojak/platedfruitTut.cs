using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platedfruitTut : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rojakTutFlow.stepCounter == 17) {
            Destroy(gameObject);
        }
        
    }

}
