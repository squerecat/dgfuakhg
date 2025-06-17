using UnityEngine;


public class move2 : MonoBehaviour
{
    public Vector2 move;
    public float speed = 3f, x = 0, y = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = 0;y = 0;
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
        move = new Vector2(x, y);
        move.Normalize();
        transform.Translate(move * Time.deltaTime * speed);
        
    }
}
