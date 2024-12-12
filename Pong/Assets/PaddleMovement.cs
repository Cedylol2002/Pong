using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 10f; // Bewegungsgeschwindigkeit
    public float maxHeight = 4.5f; // Maximale Höhe
    public float minHeight = -4.5f; // Minimale Tiefe
    public bool isPlayerOne; // Gibt an, ob es sich um den linken Spieler handelt (Player 1)

    void Update()
    {
        float moveInput = 0;

        // Steuerung für Spieler 1 (WASD)
        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.W)) moveInput = 1;
            else if (Input.GetKey(KeyCode.S)) moveInput = -1;
        }
        // Steuerung für Spieler 2 (Pfeiltasten)
        else
        {
            if (Input.GetKey(KeyCode.UpArrow)) moveInput = 1;
            else if (Input.GetKey(KeyCode.DownArrow)) moveInput = -1;
        }

        // Bewegung basierend auf Input
        Vector3 newPosition = transform.position + new Vector3(0, moveInput * speed * Time.deltaTime, 0);

        // Begrenzung der Position (Maximale Höhe und Tiefe)
        newPosition.y = Mathf.Clamp(newPosition.y, minHeight, maxHeight);

        // Neue Position setzen
        transform.position = newPosition;
    }
}
