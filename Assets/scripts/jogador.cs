using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public Rigidbody2D rb;

  void Update()
    {
        Move();
        Jump();
        tamanho();
    }
    void Move()
    {
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += movement*Time.deltaTime * Speed;
    }
    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
           rb.AddForce(new Vector2(0f,9.3f),ForceMode2D.Impulse);
            
        }

    }

        void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
        
    }
    void OnCollisionExit2D (Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }
    public void tamanho(){
    if(Input.GetKey(KeyCode.X)) 
    {
        float scale = 0.05f;
        transform.localScale += new Vector3(scale,scale,0);
    }
    if(Input.GetKey(KeyCode.Z)) 
    {
        float scale = -0.05f;
        transform.localScale += new Vector3(scale,scale,0);
    }
    }
}
