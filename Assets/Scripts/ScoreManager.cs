using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    [SerializeField] private TextMeshProUGUI scoreText;

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

    public static void UpdateScore()
    {
        instance.IncreaseScore();
    }
}
