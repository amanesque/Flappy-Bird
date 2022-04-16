using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameoverCanvas;

    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    private void EnableGameOverCanvas()
    {
        gameoverCanvas.SetActive(true);
    }

    public static void UpdateScore()
    {
        instance.IncreaseScore();
    }

    public static void GameOver()
    {
        instance.EnableGameOverCanvas();
    }
}
