using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeState : MonoBehaviour
{
    public float intervaloDeTiempo = 2.0f;
    public Sprite[] imagenes;
    public float tiempoDeFade = 1.0f;

    private Image imagen;
    private int indiceActual = 0;
    private float tiempoPasado = 0.0f;
    private bool enTransicion = false;
    private float tiempoInicioTransicion = 0.0f;
    private Color colorTransparente = new Color(1f, 1f, 1f, 0f);

    void Start()
    {
        imagen = GetComponent<Image>();

        if (imagenes.Length > 0)
        {
            ShuffleArray(imagenes);
            imagen.sprite = imagenes[indiceActual];
        }
        else
        {
            Debug.LogError("No se han asignado imágenes.");
        }
    }

    void Update()
    {
        tiempoPasado += Time.deltaTime;

        if (!enTransicion && tiempoPasado >= intervaloDeTiempo)
        {
            StartCoroutine(FadeToNextImage());
        }
    }

    IEnumerator FadeToNextImage()
    {
        enTransicion = true;
        tiempoInicioTransicion = Time.time;

        while (Time.time - tiempoInicioTransicion <= tiempoDeFade)
        {
            float factor = (Time.time - tiempoInicioTransicion) / tiempoDeFade;
            imagen.color = Color.Lerp(Color.white, colorTransparente, factor);
            yield return null;
        }

        indiceActual = (indiceActual + 1) % imagenes.Length;
        imagen.sprite = imagenes[indiceActual];

        tiempoPasado = 0.0f;
        tiempoInicioTransicion = Time.time;

        while (Time.time - tiempoInicioTransicion <= tiempoDeFade)
        {
            float factor = (Time.time - tiempoInicioTransicion) / tiempoDeFade;
            imagen.color = Color.Lerp(colorTransparente, Color.white, factor);
            yield return null;
        }

        enTransicion = false;
    }

    private void ShuffleArray<T>(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, array.Length);
            T tempItem = array[randomIndex];
            array[randomIndex] = array[i];
            array[i] = tempItem;
        }
    }
}
