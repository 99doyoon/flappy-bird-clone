using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static bool isGameOver = false;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI highScoreText;

    public int highScore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        isGameOver = false;

        highScore = PlayerPrefs.GetInt("HighScore", 0);

        UpdateScore();
    }

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore()
    {
        score++;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
        highScoreText.text = "HighScore : " + highScore;
    }

    public static void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over");
    }
}