using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float _posicaox;
    [SerializeField] float _posicaoy;

    [SerializeField] Vector2 _posicao;

    [SerializeField] Rigidbody2D _rig2d;
    void Start()
    {
        _rig2d = GetComponent<Rigidbody2D>();
        _rig2d.angularVelocity = 0; 
    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _posicao = value.ReadValue<Vector2>();

    }
    void Update()
    {
        
    }

}
