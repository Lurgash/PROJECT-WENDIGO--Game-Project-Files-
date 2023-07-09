using UnityEngine;

public class TextShake : MonoBehaviour
{
    public float shakeSpeed = 1f; 
    public float shakeAmount = 10f; 

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
        
        transform.position = initialPosition;
    }

    void Shake()
    {
        
        Vector3 randomOffset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * shakeAmount;
        transform.position = initialPosition + randomOffset * Time.deltaTime * shakeSpeed;
    }
}