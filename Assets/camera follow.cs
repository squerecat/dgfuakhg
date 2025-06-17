using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Vector2 position;
    public GameObject player;
    public float speed = 5f , distancex = 5f , distancey = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = player.transform.position - transform.position;
            

            transform.Translate(position * speed * Time.deltaTime);
        
    }
}
