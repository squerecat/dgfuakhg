using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerWeapons : MonoBehaviour
{
    public Quaternion rotation;
    public int trigger = 0;

    [Header("Gun")]
    public float fireRate = 0.2f;
    public int magSize = 15;
    public GameObject bullet;
    public float reloadTime = 2.0f;

    [Header("Sword")]
    public float stabRate = 0.5f;
    public GameObject sword;


    public int mag = 0;
    public bool reloading = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mag = magSize;
    }
    float fireCounter = 0.0f, stabCounter = 0.0f;
    float reloadCounter = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        if (trigger == 0)
        {
            fireCounter += Time.deltaTime;
            stabCounter += Time.deltaTime;

            //검 찌르기
            if (Input.GetMouseButtonDown(1) && stabCounter >= stabRate)
            {
                stabCounter = 0.0f;
                Instantiate(sword, transform.position, rotation, transform);
            }

            //총 재장전 & 사격
            if (reloading)
            {
                reloadCounter += Time.deltaTime;
                if(reloadCounter >= reloadTime)
                {
                    mag = magSize;
                    reloading = false;
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0) && fireCounter >= fireRate && mag > 0)
                {
                    fireCounter = 0.0f;
                    mag--;
                    Instantiate(bullet, transform.position, rotation);
                }
                if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.E)) && mag < magSize)
                {
                    reloadCounter = 0.0f;
                    reloading = true;
                }
            }
        }
        else if (trigger == 1)
        {

        }
    }
}
