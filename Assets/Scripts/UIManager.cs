using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public static UIManager Instance
    {
        get { return instance; }
    }

    [SerializeField] private GameObject gameoverCanvas;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        GameManager.OnScoreIncrease += GameManager_OnScoreIncrease;
        GameManager.OnGameOver += GameManager_OnGameOver;
        GameManager.OnGameRestart += GameManager_OnGameRestart;
    }

    private void GameManager_OnGameRestart()
    {
        gameoverCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GameManager_OnGameOver()
    {
        gameoverCanvas.SetActive(true);
    }

    private void GameManager_OnScoreIncrease(int score)
    {
        scoreText.text = score.ToString();
    }

    private void OnDisable()
    {
        GameManager.OnScoreIncrease -= GameManager_OnScoreIncrease;
        GameManager.OnGameOver -= GameManager_OnGameOver;
        GameManager.OnGameRestart -= GameManager_OnGameRestart;
    }
}
