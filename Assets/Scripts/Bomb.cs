using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int damage;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().ChangeHP(damage);
            DestroyBomb();
        }

        else if (other.CompareTag("Ally"))
        {
            other.GetComponent<Ally>().ChangeHP(damage);
            DestroyBomb();
        }
    }




    private void DestroyBomb()
    {
        Destroy(gameObject);
    }
}
