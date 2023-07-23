using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    //public timerslider timerScript;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("Click");
        SceneManager.LoadScene(1);
        //timerScript.RestartTimer();
    } 

    // Update is called once per frame
    void Update()
    {
        
    } 
}
