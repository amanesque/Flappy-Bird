using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float upForce = 5.0f;
    [SerializeField] private float upAngle = 20.0f;

    private Rigidbody2D rigidbody;
    private BoxCollider2D collider;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);
            transform.rotation = Quaternion.Euler(0, 0, upAngle);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
