using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;

    public float speed = 32;
    
    private Animator animator;
    public float animatorSpeed;
    public float verticalAnimatorSpeed;
    public float horizontalAnimatorSpeed;
    public Sprite sprite;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<Sprite>();
    }

    
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        

        if (hor != 0 || ver != 0)
        {
            Vector2 velocity = new Vector2(hor, ver).normalized * speed;

            rigidbody2D.velocity = velocity;

            
            horizontalAnimatorSpeed = Mathf.Abs(rigidbody2D.velocity.x);
            verticalAnimatorSpeed = Mathf.Abs(rigidbody2D.velocity.y);

            
            animator.SetFloat("Horizontal", hor);
            animator.SetFloat("Vertical", ver);

        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
            hor = 0f;
            ver = 0f;

            animator.SetFloat("Horizontal", hor);
            animator.SetFloat("Vertical", ver);


        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
