using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f; // Geschwindigkeit des Balls
    private Vector2 direction; // Richtung des Balls

    void Start()
    {
        // Zufällige Start-Richtung generieren
        direction = Random.insideUnitCircle.normalized;
    }

    void Update()
    {
        // Ballbewegung
        transform.Translate(direction * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.transform.position = Vector3.zero;
            direction = Random.insideUnitCircle.normalized;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reflexion der Richtung bei einer Kollision
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Border"))
        {
            Vector2 normal = collision.contacts[0].normal;
            direction = Vector2.Reflect(direction, normal).normalized;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            collision.gameObject.GetComponent<Goal>().Score();
        }

        RestartBall();
    }

    private void RestartBall()
    {
        // Ball zurücksetzen
        transform.position = Vector3.zero;
        direction = Random.insideUnitCircle.normalized;
    }
}
