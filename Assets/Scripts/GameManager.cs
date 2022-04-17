using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        UIManager.Instance.EnableGameOverCanvas();
    }

    public void RestartGame()
    {
        UIManager.Instance.DisableGameOverCanvas();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore()
    {
        ScoreManager.Instance.UpdateScore();
    }
}
