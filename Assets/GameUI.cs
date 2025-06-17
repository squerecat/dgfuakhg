using TMPro;
using UnityEngine;


public class GameUI : MonoBehaviour
{
    public Transform hpBarFill;
    public TMP_Text magText;
    PlayerHP playerHP;
    PlayerWeapons playerWeapons;
    private void Start()
    {
        GameObject player = GameObject.Find("player");
        playerHP = player.GetComponent<PlayerHP>();
        playerWeapons = player.GetComponent<PlayerWeapons>();
    }
    private void Update()
    {
        hpBarFill.localScale = new Vector2(playerHP.hp / playerHP.maxHp, 1.0f);
        if (playerWeapons.reloading)
        {
            magText.text = "Reloading...";
        }
        else
        {
            magText.text = $"{playerWeapons.mag} / {playerWeapons.magSize}";
        }
    }
}