using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager Instance
    {
        get { return instance; }
    }

    private TextMeshProUGUI scoreText;

    private int score = 0;

    private void Awake()
    {
        instance = this;

        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
