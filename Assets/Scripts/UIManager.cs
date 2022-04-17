using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public static UIManager Instance
    {
        get { return instance; }
    }

    private GameObject gameoverCanvas;

    private void Awake()
    {
        instance = this;

        gameoverCanvas = transform.GetChild(0).gameObject;
    }

    public void EnableGameOverCanvas()
    {
        gameoverCanvas.SetActive(true);
    }
    public void DisableGameOverCanvas()
    {
        gameoverCanvas.SetActive(false);
    }
}
