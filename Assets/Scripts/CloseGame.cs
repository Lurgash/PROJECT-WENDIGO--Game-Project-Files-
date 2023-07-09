using UnityEngine;

public class CloseGame : MonoBehaviour
{
    private void Start()
    {
        Invoke("CerrarJuego", 6f); 
    }

    private void CerrarJuego()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
        Application.Quit(); 
#endif
    }
}
