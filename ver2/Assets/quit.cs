using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class quit : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(0);
        gameflow.customersServed = 0;
    }
}