using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;

    public float speed = 32;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");


        if (hor !=0 || ver !=0 )
        {
            Vector2 velocity = new Vector2(hor, ver) * speed;

            rigidbody2D.velocity = velocity;

        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
