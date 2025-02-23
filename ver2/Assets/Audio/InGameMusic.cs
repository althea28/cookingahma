using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class InGameMusic : MonoBehaviour
{
    public static InGameMusic instance;
 
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