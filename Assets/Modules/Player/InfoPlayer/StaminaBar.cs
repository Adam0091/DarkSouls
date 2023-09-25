using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Image staminaBar;
    public PlayerController player;
    private const float SPEED = 30f;
    void Start()
    {
        staminaBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        staminaBar.fillAmount = player.Stamina / player.MaxStamina;
        if (player.Stamina < player.MaxStamina)
        {
            player.Stamina += SPEED * Time.deltaTime;
        }

        if(player.Stamina > player.MaxStamina)
        {
            player.Stamina = player.MaxStamina;
        } 
    }
}
