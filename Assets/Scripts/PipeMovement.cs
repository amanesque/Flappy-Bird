using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;

    private BoxCollider2D scoreTrigger;

    private void Awake()
    {
        scoreTrigger = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.UpdateScore();
        }
    }
}
