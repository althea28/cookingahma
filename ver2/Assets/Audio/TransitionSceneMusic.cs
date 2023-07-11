using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TransitionSceneMusic : MonoBehaviour
{
    public static TransitionSceneMusic instance;
 
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}