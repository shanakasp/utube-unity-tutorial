using System.Collections;
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
    [SerializeField] Transform _bulletSpawn;

    bool _isShooting = false;
    float _ballSpeed = 15f;

    float _moveHorizontal;
    float _moveVertical;

    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
        _moveVertical = Input.GetAxisRaw("Vertical");

        _moveVelocity = new Vector2(_moveHorizontal, _moveVertical) * _moveSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            _isShooting = true;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();

        if (_isShooting)
        {
            StartCoroutine(Fire());
            _isShooting = false;
        }
    }

    void MovePlayer()
    {
        if (_moveHorizontal != 0 || _moveVertical != 0)
        {
            if (_moveHorizontal != 0 && _moveVertical != 0)
            {
                _moveVelocity *= _speedLimiter;
            }

            _rb.velocity = _moveVelocity;
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }
    }

    void RotatePlayer()
    {
        _mousePos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = _mousePos - _rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        _rb.rotation = angle;
    }

    IEnumerator Fire()
    {
        GameObject bullet = Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(_bulletSpawn.up * _ballSpeed, ForceMode2D.Impulse);
        yield return null;
    }
}
