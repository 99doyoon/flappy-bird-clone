using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        if (GameManager.isGameOver) return;

        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
//왼쪽으로 이동 화면 밖 → 삭제