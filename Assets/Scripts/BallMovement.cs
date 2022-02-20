using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    float m_Speed = 1.0f;
    private Rigidbody2D rb;
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isActive = true;
            rb.gravityScale = 1f;
        }


        if(isActive != true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * m_Speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * m_Speed * Time.deltaTime);
            }
        }
        
        
    }
}
