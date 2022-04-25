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

    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        BirdController.OnPlayerCrash += BirdController_OnPlayerCrash;
        BirdController.OnRestart += BirdController_OnRestart;

        PipeMovement.OnObstacleClear += PipeMovement_OnObstacleClear;
    }

    private void PipeMovement_OnObstacleClear()
    {
        score++;

        if (OnScoreIncrease != null)
        {
            OnScoreIncrease(score);
        }
    }

    private void BirdController_OnRestart()
    {
        if (OnGameRestart != null)
        {
            OnGameRestart();
        }
    }

    private void BirdController_OnPlayerCrash()
    {
        if (OnGameOver != null)
        {
            OnGameOver();
        }
    }

    private void OnDisable()
    {
        BirdController.OnPlayerCrash -= BirdController_OnPlayerCrash;
        BirdController.OnRestart -= BirdController_OnRestart;

        PipeMovement.OnObstacleClear -= PipeMovement_OnObstacleClear;
    }

    public delegate void ScoreIncreased(int score);
    public static event ScoreIncreased OnScoreIncrease;

    public delegate void GameOver();
    public static event GameOver OnGameOver;

    public delegate void GameRestarted();
    public static event GameRestarted OnGameRestart;
}
