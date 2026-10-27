using System;
using UnityEngine;

public class movimentosJogador : MonoBehaviour
{
    float horizontalInput;
    float VelocidadeMovimento = 5f;
    bool olhandodireita = false;
    float ForcaPulo = 10f;
    bool chao = true;
    bool ataque = true;

    Rigidbody2D RB;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     RB = GetComponent<Rigidbody2D>();
     animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        FlipSprite();

        if (Input.GetButtonDown("Jump") && !chao)
        {
            RB.linearVelocity = new Vector2(RB.linearVelocityX, ForcaPulo);
            chao = true;
            animator.SetBool("Pulando", !chao);
        }

        if (Input.GetKeyDown(KeyCode.C) && !chao)
        {

            animator.SetBool("ataque",true);
        }
    }   

    private void FixedUpdate()
    {
        RB.linearVelocity = new Vector2(horizontalInput * VelocidadeMovimento, RB.linearVelocity.y);
        animator.SetFloat("Xvelocity", Math.Abs(RB.linearVelocity.x));
        animator.SetFloat("Yvelocity", RB.linearVelocity.x);
    }

    void FlipSprite()
    {
        if (olhandodireita && horizontalInput > 0f || !olhandodireita && horizontalInput < 0f) 
        {
          olhandodireita = !olhandodireita;
            Vector3 escala = transform.localScale;
            escala.x *= -1f;
            transform.localScale = escala;        
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        chao = false;
        animator.SetBool("Pulando", !chao);
    }
}

