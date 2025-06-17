using UnityEngine;

public class reload : MonoBehaviour
    
{
    public GameObject player;
    public int shoot = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot++;
            
        }
        if (shoot >= 15)
        {
            shoot = 15;
            player.GetComponent<PlayerWeapons>().trigger = 1;

        }

    }
}
