using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBrun : MonoBehaviour
{
    


    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name == "Personnage")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }


}
