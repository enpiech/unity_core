﻿using UnityEngine;

namespace Enpiech.Core.Runtime
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        private static readonly object _instanceLock = new();
        private static bool _quitting = false;

        public static T Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance != null || _quitting)
                    {
                        return _instance;
                    }
                    _instance = FindObjectOfType<T>();
                    if (_instance != null)
                    {
                        return _instance;
                    }
                    var go = new GameObject(typeof(T).ToString());
                    _instance = go.AddComponent<T>();

                    DontDestroyOnLoad(_instance.gameObject);

                    return _instance;
                }
            }
        }

        protected virtual void Awake()
        {
            if (_instance == null) _instance = gameObject.GetComponent<T>();
            else if (_instance.GetInstanceID() != GetInstanceID())
            {
                Destroy(gameObject);
                throw new System.Exception($"Instance of {GetType().FullName} already exists, removing {ToString()}");
            }
        }

        protected virtual void OnApplicationQuit()
        {
            _quitting = true;
        }
    }
}