using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveInput, 0f);
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Hit");
            Rigidbody2D ballRb = other.GetComponent<Rigidbody2D>();
            if (ballRb != null)
            {
                Vector2 hitDirection = (other.transform.position - transform.position).normalized;
                ballRb.AddForce(hitDirection * 10f, ForceMode2D.Impulse);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Exit");
        }
    }
}
