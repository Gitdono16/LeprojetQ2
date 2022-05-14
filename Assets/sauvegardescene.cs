using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sauvegardescene : MonoBehaviour
{

    public GameObject[] objects; 


    void Awake()
    {
        foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        
        }
    }

 
}
