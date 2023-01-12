using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using Image = UnityEngine.UI.Image;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI caracterHealthText;
    
    [SerializeField] IntVariable caracterHP;

    [SerializeField] private Image healthBar;

    private int maxHealth;
    private int lastCaraterHP;

    private void Start()
    {
        maxHealth = caracterHP.value;
        ChangeCaracterHealthDisplay();
    }
        
    private void Update()
    {
        if (lastCaraterHP != caracterHP.value)
        {
            ChangeCaracterHealthDisplay();
            HealthBarChange(lastCaraterHP);
        }
        
    }


    public void ChangeCaracterHealthDisplay()
    {
        lastCaraterHP = caracterHP.value;
        caracterHealthText.text = caracterHealthText.text = "HP : " + lastCaraterHP;      
    }


    public void HealthBarChange(int health)
    {
        Debug.Log("Méthode TakeDamage appelée, HP restants : " + health);
        Debug.Log((float)(health / maxHealth));
    }

}