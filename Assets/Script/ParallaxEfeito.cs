using Unity.VisualScripting;
using UnityEngine;

public class ParalaxController : MonoBehaviour
{
    private float PosicaoInicio;
    public GameObject cam;
    public float parallaxEfeito; //velocidade do efeito de parallax
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PosicaoInicio = transform.position.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distancia = cam.transform.position.x * parallaxEfeito; //0 = mover com a camera || 1 = nem um movimento
        

        transform.position = new Vector3(PosicaoInicio + distancia, transform.position.y, transform.position.z);
    }
}
