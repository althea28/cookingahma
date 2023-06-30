using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnToastTutorial : MonoBehaviour
{
    public Transform steamObj;
    private static float cookedTimeB = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(steamObj, transform.position, steamObj.rotation);   
        cookedTimeB = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((cookedTimeB < tutorialflow.timeToCook) && (transform.position == tutorialflow.grillBCoordinates)) 
        {
            cookedTimeB += Time.deltaTime;
        }
        if (cookedTimeB >= tutorialflow.timeToCook) 
        {
            tutorialflow.changeInnerB = "y";
        }
        
    }
}
