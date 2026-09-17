using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    // Variável para definir a velocidade horizontal do jogador
    [SerializeField] float _velocidadeX;
    // Variável para armazenar a posição do jogador com base no input
    [SerializeField] Vector2 _posicao;
    // Variável para armazenar o componente Rigidbody2D do jogador
    [SerializeField] Rigidbody2D _rig2d;
    // Variável para verificar se o jogador está no chão
    [SerializeField] bool _checkGround;
    // Variável para armazenar a força de pulo do jogador
    void Start()
    {
        //Procura e atribui o componente Rigidbody2D do objeto atual à variável _rig2d
        _rig2d = GetComponent<Rigidbody2D>();

    }

    // Método chamado quando o jogador fornece input de movimento
    public void SetMove(InputAction.CallbackContext value)
    {
        // Lê o valor do input e atribui à variável _posicao
        _posicao = value.ReadValue<Vector2>();
    }
    // Método chamado quando o jogador fornece input de pulo
    public void SetJump(InputAction.CallbackContext value)
    {
        // Verifica se o botão de pulo foi pressionado e se o jogador está no chão
        if (_checkGround == true)
        {
            // Adiciona uma força vertical ao Rigidbody2D para fazer o jogador pular
            _rig2d.AddForceY(180);
            Debug.Log("pulo");
        }
    }
    // Método chamado a cada frame para atualizar a lógica do jogador
    void Update()
    {
        // Atualiza a velocidade horizontal do Rigidbody2D com base na posição e velocidade definidas
        _rig2d.linearVelocityX = _posicao.x * _velocidadeX;
    }
    // Método chamado quando o jogador entra em uma colisão com outro objeto
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o jogador colidiu com o chão
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Se colidiu, define _checkGround como true e exibe uma mensagem no console
            Debug.Log("tocou no chão");
            _checkGround = true;
        }
    }
    // Método chamado quando o jogador sai de uma colisão com outro objeto
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Verifica se o jogador saiu da colisão com o chão
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Se saiu, define _checkGround como false e exibe uma mensagem no console
            Debug.Log("saiu do chão");
            _checkGround = false;
        }
    }

}
