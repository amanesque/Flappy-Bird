using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float upForce = 5.0f;
    [SerializeField] private float upAngle = 20.0f;

    private Rigidbody2D birdRigidbody;
    private CapsuleCollider2D birdCollider;

    private bool isAlive = true;

    private void Awake()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
        birdCollider = GetComponent<CapsuleCollider2D>();
    }

    private void Update()
    {
        if (isAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                birdRigidbody.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);
                transform.rotation = Quaternion.Euler(0, 0, upAngle);
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                transform.rotation = Quaternion.identity;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isAlive = true;
                Time.timeScale = 1.0f;
                GameManager.Instance.RestartGame();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isAlive = false;
            Time.timeScale = 0.0f;
            GameManager.Instance.GameOver();
        }
    }
}
