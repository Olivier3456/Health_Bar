using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] private int initialHealth = 100;
    private int health;
    public int Health
    {
        get { return health; }
    }

    [SerializeField] private Transform player;

    [SerializeField] private float followDistance = 2f;
    [SerializeField] private float allySpeed = 0.5f;

    [SerializeField] private HealthDisplay healthDisplay;


    private void Start()
    {
        health = initialHealth;
        healthDisplay.ChangeAllyHealthDisplay(health);
    }


    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) >= followDistance)
        {
            transform.position += (player.position - transform.position).normalized * allySpeed * Time.deltaTime;
        }
    }


    public void ChangeHP(int hpToRemoveOrAdd)
    {
        health -= hpToRemoveOrAdd;
        healthDisplay.ChangeAllyHealthDisplay(health);        
    }
}
