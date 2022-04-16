using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPipePair : MonoBehaviour
{
    [SerializeField] private GameObject pipeDown;
    [SerializeField] private GameObject pipeUp;

    private SpriteRenderer topPipe;
    private SpriteRenderer bottomPipe;

    private float spriteHalfHeight;

    private void Awake()
    {
        topPipe = pipeUp.GetComponentInChildren<SpriteRenderer>();
        bottomPipe = pipeDown.GetComponentInChildren<SpriteRenderer>();

        spriteHalfHeight = topPipe.bounds.size.y / 2;
    }

    private void OnEnable()
    {
        float bottomPosY = Random.Range(-3.5f, -2.25f);
        float topPosY = Random.Range(4.0f, 5.5f);

        pipeDown.transform.SetPositionAndRotation(new Vector3(pipeDown.transform.position.x, bottomPosY, pipeDown.transform.position.z), Quaternion.identity);
        pipeUp.transform.SetPositionAndRotation(new Vector3(pipeUp.transform.position.x, topPosY, pipeUp.transform.position.z), Quaternion.identity);
    }
}
