using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 2f;
    public float resetPosition = -20f;
    public float startPosition = 20f;

    void Update()
    {
        if (GameManager.isGameOver) return;

        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < resetPosition)
        {
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }
    }
}