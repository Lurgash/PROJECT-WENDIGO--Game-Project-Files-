using UnityEngine;
using UnityEngine.UI;

public class CambiarCapaImagenUI : MonoBehaviour
{
    public Image imagen;
    public string nuevaCapa = "TuNuevaCapa"; 

    void Start()
    {
        if (imagen != null)
        {
            CambiarLayerImagenUI(imagen, nuevaCapa);
        }
        else
        {
            Debug.LogError("No se ha asignado la imagen de UI.");
        }
    }

    void CambiarLayerImagenUI(Image imageUI, string nuevaLayer)
    {
        Canvas canvas = imageUI.canvas;
        imageUI.gameObject.layer = LayerMask.NameToLayer(nuevaLayer);
        canvas.overrideSorting = true;
        canvas.sortingOrder = 1; 
    }
}
