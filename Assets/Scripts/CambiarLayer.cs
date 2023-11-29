using UnityEngine;

public class CambiarLayer : MonoBehaviour
{
    public int nuevoLayer = -1; 

    void Start()
    {
        gameObject.layer = nuevoLayer;
    }
}
