using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 8f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameManager.isGameOver) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
    }
}