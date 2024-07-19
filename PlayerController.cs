using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] ObjectBehaviour _objectBehavior;

    float _playerSpeed = 10.5f;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _objectBehavior.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectBehaviour.GameOver)
            return;

        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            _rb.velocity = new Vector2(_inputHorizontal * _playerSpeed, _rb.velocity.y);
        }
        else
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
        }
    }
}
