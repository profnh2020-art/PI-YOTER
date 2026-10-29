using UnityEngine;

public class Ataque : MonoBehaviour
{

    bool chao =true;
    bool ataque = true;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Input.GetKeyDown("Attack"))
        {
            animator.SetBool("soco", !chao);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("ataque realizado!");
        }
    }
}
