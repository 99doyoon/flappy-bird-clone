using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene("GameScene");
    }
}