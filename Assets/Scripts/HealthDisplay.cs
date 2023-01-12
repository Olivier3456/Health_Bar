using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshPro healthTextOnPlayer;
    
    public void ChangeHealthDisplay(int playerHealth)
    {
        healthText.text = healthTextOnPlayer.text = "Player HP = " + playerHealth;      
    }
}
