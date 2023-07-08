using UnityEngine;

public class TextShake : MonoBehaviour
{
    public float shakeSpeed = 1f; // Velocidad del temblor
    public float shakeAmount = 10f; // Intensidad del temblor

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
        StartShake();
    }

    void Update()
    {
        Shake();
    }

    void StartShake()
    {
        // Inicia el temblor estableciendo la posici�n inicial
        transform.position = initialPosition;
    }

    void Shake()
    {
        // Genera una posici�n temblorosa en base a la posici�n inicial
        Vector3 randomOffset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * shakeAmount;
        transform.position = initialPosition + randomOffset * Time.deltaTime * shakeSpeed;
    }
}