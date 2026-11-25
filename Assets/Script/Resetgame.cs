using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetgame : MonoBehaviour
     
{
    void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.name == "Zona_reset")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
