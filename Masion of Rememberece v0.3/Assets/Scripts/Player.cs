using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D playerRb;
    public Animator animator;

    Vector2 movimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movimento.x);
        animator.SetFloat("Vertical", movimento.y);
        animator.SetFloat("Velocidade", movimento.sqrMagnitude);

        if(movimento != Vector2.zero)
        {
            animator.SetFloat("HorizontalIdle", movimento.x);
            animator.SetFloat("VerticalIdle", movimento.y);
        }



    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movimento * speed * Time.fixedDeltaTime);
    }
}
