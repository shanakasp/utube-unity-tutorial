using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour

{
   int _playerHealth = 100;

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

    public string DsiplayHealthPlayer
    {
        get
        {
            return _playerHealth.ToString() + "%";
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DsiplayHealthPlayer);
        PlayerHealth = 50;
    }

    // Update is called once per frame
  
}
