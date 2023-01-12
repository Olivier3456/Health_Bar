using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int initialHealth = 100;
    private int health;
    public int Health
    {
        get { return health; }
    }

    [SerializeField] private HealthDisplay healthDisplay;
    [SerializeField] private HealthBar healthBar;


    void Start()
    {
        health = initialHealth;
        healthDisplay.ChangePlayerHealthDisplay(health);
    }
    public void ChangeHP(int hpToRemoveOrAdd)
    {
        health -= hpToRemoveOrAdd;
        healthDisplay.ChangePlayerHealthDisplay(health);
        healthBar.TakeDamage(health);
    }
}
