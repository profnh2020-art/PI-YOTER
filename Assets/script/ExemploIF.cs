using UnityEngine;

public class ExemploIF : MonoBehaviour
    
{ 
    public int vida = 100;
    public int pontos = 1000;

    void Start()
    {
        if (vida == 100)
        {
            Debug.Log("jogador vivo");
        }
        if (vida != 99)
        {
            Debug.Log("Jogador não está morto");
        }
        
    }


    void Update()
    {
        if (pontos <= 0)
        {
            Debug.Log("Você morreu");
        }

     
        if (pontos > 1000)
        {
            Debug.Log("pontuação alta");
        }
    }
}
