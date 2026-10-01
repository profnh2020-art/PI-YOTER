using UnityEngine;


public class ExemploIF : MonoBehaviour    
{
    public int vida = 100;
    public int pontos = 100;

    void Start()
    {
        if (vida == 100)
        {
            Debug.Log("player está vivo");
        }else if (vida == 0)
                    {
            Debug.Log("player morreu");
        }
        if (vida != 0)
        {
            Debug.Log("player está diferente de 0");
        }
        if (vida > 100)
        {
            Debug.Log("player está com vida extra");
        }
        if (pontos >= 100)
        {
            Debug.Log("Pontuação Alta!");
        }

    }

    void Update()
    {
        
    }

}
