using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour

{
   int _playerHealth = 100;
    int _playerShield = 50;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }

        set
        {
            _playerHealth = value;
        }
    }

    public int PlayerSheild
    {
        get
        {
            return _playerShield;
        }

        set
        {
            _playerShield = value;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("You Took " + DamageTaken(80) + " In Damage");
    }

  int DamageTaken(int damage)
    {
        int damageTaken ;

        if (damage< PlayerSheild)
        {
            Debug.Log("Shield not destroyed");
            damageTaken = 0;
        }
        else if(damage == PlayerSheild)
        {
            Debug.Log("Shield destroyed");
            damageTaken = 0;
        }
        else
        {
            Debug.Log("Shield destroyed");
            damageTaken = damage - PlayerSheild;
        }

        return damageTaken;
    }
   
}
