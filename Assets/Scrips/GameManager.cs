using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Transform startTrsPoint;

    public static GameManager instance;

    void Awake()
    {
        if(instance) {
            
            Destroy(gameObject);
        
        } else {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    public Vector3 startPoint => startTrsPoint.position;
    
}
