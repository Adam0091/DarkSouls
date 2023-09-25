using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Image healthBar;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = player.Hp / player.MaxHp;
    }
}
