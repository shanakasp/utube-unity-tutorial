//Move object left or right


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody2D _rb;
    float _walkSpeed;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _walkSpeed = 0.5f; // Adjust this value as needed
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            // Move the object left or right by a fixed amount
            transform.Translate(new Vector2(_inputHorizontal * _walkSpeed, 0));
        }
    }
}
