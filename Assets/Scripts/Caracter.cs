using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracter : MonoBehaviour
{   
    //private int health;
    //public int Health
    //{
    //    get { return health; }
    //}
       
    [SerializeField] private IntVariable HP;
    
    public void ChangeHP(int hpToRemoveOrAdd)
    {
        HP.value -= hpToRemoveOrAdd;
    }
}
