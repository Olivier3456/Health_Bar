using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float maxHealth = 100f;
    

    [SerializeField] private Player player;

   

    public void TakeDamage(float health)
    {        
        healthBar.fillAmount = health / maxHealth;     
        Debug.Log("M�thode TakeDamage appel�e, HP restants : " + health);
    }
}