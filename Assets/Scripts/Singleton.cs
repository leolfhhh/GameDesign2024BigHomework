using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
where T : MonoBehaviour
{
    public bool global = true;
    private static T _instance;

    private static T Instance
    {
        get
        {
            _instance ??= FindObjectOfType<T>();
            return _instance;
        }
    }

    private void Awake()
    {
        if (global)
        {
            DontDestroyOnLoad(this);
        }

        OnStart();
    }

    protected virtual void OnStart()
    {
        
    }
}
