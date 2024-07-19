using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    private static bool _gameOver = false;

    public static bool GameOver
    {
        get { return _gameOver; }
    }

    public void SpawnObject()
    {
        if (!_gameOver)
        {
            Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), 10f, 0f), Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !_gameOver)
        {
            SpawnObject();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            _gameOver = true;
            Debug.Log("Game Over!");
            // Additional game over logic can be added here
        }
    }
}
