using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnRate = 2f;

    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnRate)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-2f, 2f);

        Instantiate(pipePrefab, new Vector3(10f, randomY, 0), Quaternion.identity);
    }
}