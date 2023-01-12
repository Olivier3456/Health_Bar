using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caracter"))
        {
            other.GetComponent<Caracter>().ChangeHP(damage);
            DestroyBomb();
        }        
    }

    private void DestroyBomb()
    {
        Destroy(gameObject);
    }
}
