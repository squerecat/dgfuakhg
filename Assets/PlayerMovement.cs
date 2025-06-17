using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0, y = 0;
        if (Input.GetKey(KeyCode.W))
        {
            y = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }
        Vector2 move = new Vector2(x, y);
        move.Normalize();
        //transform.Translate(move * Time.deltaTime * speed);
        //transform.Translate, rb.MovePosition은 벽 충돌 무시
        rb.linearVelocity = move * speed;
    }
}
