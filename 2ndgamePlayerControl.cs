using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    GameManger _gameManager;
    Rigidbody2D _rb;
    Camera _mainCamera;
    float _moveSpeed = 5f;
    float _speedLimiter = 0.7f;
    Vector2 _moveVelocity;

    Vector2 _mousePos;
    Vector2 _offSet;

    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _bulletSpawn;

    bool _isShooting = false;
    float _ballSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
