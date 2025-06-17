using UnityEngine;


public class PlayerHP : MonoBehaviour
{
    public float maxHp = 100.0f;
    public float hp;
    private void Start()
    {
        hp = maxHp;
    }
    public void GetDamage(float damage)
    {
        hp = Mathf.Max(hp - damage, 0);
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}