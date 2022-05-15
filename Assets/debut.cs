using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debut : MonoBehaviour
{
    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position; 
    }
    
}
