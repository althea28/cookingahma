using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class quit : MonoBehaviour
{
    public AudioSource soundPlayer;
    
    public void OnMouseDown()
    {
        soundPlayer.Play();
        DontDestroyOnLoad(soundPlayer.gameObject);
        SceneManager.LoadScene(0);
        gameflow.customersServed = 0;
    }
}