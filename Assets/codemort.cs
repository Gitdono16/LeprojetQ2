
using UnityEngine;

public class codemort : MonoBehaviour
{
    Transform Debut; 

    private void Awake()

    {
        Debut = GameObject.FindGameObjectWithTag("Debut").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))

        {
            collision.transform.position = Debut.position;

        }
    } 
        
        
 }      

