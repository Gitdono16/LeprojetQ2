
using UnityEngine;
using UnityEngine.SceneManagement;

public class autreniveau : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name == "Personnage")
        {
            SceneManager.LoadScene("Niveau2");
        }
    }
   
}
