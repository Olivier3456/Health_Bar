using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    
    public void ChangeHealthDisplay(int playerHealth)
    {
        healthText.text = "Player HP = " + playerHealth;
    }
}
