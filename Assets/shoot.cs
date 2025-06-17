using UnityEngine;
using UnityEngine.Rendering;

public class stabwhehehe : MonoBehaviour
{
    public GameObject sword;
    public GameObject bullet;
    public Quaternion rotation;
    public int trigger = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        if (trigger == 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(sword, transform.position, rotation);
            }
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, transform.position, rotation);
            }
        }
        else if (trigger == 1)
        {

        }
    }
}
