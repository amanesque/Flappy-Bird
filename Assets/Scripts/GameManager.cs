using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField] private GameObject gameoverCanvas;

    private void Awake()
    {
        instance = this;
    }

    private void EnableGameOverCanvas()
    {
        gameoverCanvas.SetActive(true);
    }
    private void DiableGameOverCanvas()
    {
        gameoverCanvas.SetActive(false);
    }

    public static void GameOver()
    {
        instance.EnableGameOverCanvas();
    }

    public static void RestartGame()
    {
        instance.DiableGameOverCanvas();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
