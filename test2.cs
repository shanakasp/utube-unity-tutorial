using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private int _playerHealth = 100;
    private float _playerSpeed = 4.6f;
    private bool _isGrounded = true;
    private string _playerName = "Shanaka";
    private Vector3 _playerPosition = new Vector3(-5f, 0f, 0f);
  

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = _playerPosition;
    }

    // Update is called once per frame
  
}
