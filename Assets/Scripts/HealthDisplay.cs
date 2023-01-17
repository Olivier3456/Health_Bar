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

    private float maxHealth;
    private float lastCaraterHP;

    private void Start()
    {
        maxHealth = caracterHP.value;
        ChangeCaracterHealthDisplay();
    }
        
    private void Update()
    {
        if (lastCaraterHP != caracterHP.value)
        {
            lastCaraterHP = caracterHP.value;
            ChangeCaracterHealthDisplay();
            HealthBarChange();
        }        
    }


    public void ChangeCaracterHealthDisplay()
    {        
        caracterHealthText.text = caracterHealthText.text = "HP : " + lastCaraterHP;      
    }


    public void HealthBarChange()
    {
        float barScaleX = lastCaraterHP / maxHealth;
        healthBar.transform.localScale = new Vector2(barScaleX, healthBar.transform.localScale.y);      
        Debug.Log(barScaleX);
    }
}