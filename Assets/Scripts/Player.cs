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


    void Start()
    {
        health = initialHealth;
        healthDisplay.ChangeHealthDisplay(health);
    }
    public void ChangeHP(int hpToRemoveOrAdd)
    {
        health -= hpToRemoveOrAdd;
        healthDisplay.ChangeHealthDisplay(health);
        Debug.Log(health);
    }
}
