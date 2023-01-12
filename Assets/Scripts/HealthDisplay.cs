using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshPro healthTextOnPlayer;

    [SerializeField] TextMeshProUGUI allyHealthText;
        
    public void ChangePlayerHealthDisplay(int playerHealth)
    {
        playerHealthText.text = healthTextOnPlayer.text = "Player HP = " + playerHealth;      
    }

    public void ChangeAllyHealthDisplay(int allyHealth)
    {
        allyHealthText.text = healthTextOnPlayer.text = "Ally HP = " + allyHealth;
    }
}
