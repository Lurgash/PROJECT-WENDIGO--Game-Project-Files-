using UnityEngine;

public class FullscreenScaler : MonoBehaviour
{
    private const float TargetWidth = 640f;
    private const float TargetHeight = 480f;
    private float targetAspect;
    private bool isFullscreen;
    private Vector3[] initialPositions;

    void Awake()
    {
        targetAspect = TargetWidth / TargetHeight;
        isFullscreen = Screen.fullScreen;
        SaveInitialPositions();
        SetFullscreenScale();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            ToggleFullscreen();
        }
    }

    void ToggleFullscreen()
    {
        isFullscreen = !isFullscreen;
        Screen.fullScreen = isFullscreen;
        if (isFullscreen)
        {
            SetFullscreenScale();
        }
        else
        {
            RestoreInitialPositions();
        }
    }

    void SetFullscreenScale()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        float scaleFactor = currentAspect / targetAspect;

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Vector3 initialPosition = initialPositions[i];
            Vector3 scaledPosition = initialPosition * scaleFactor;
            child.localPosition = scaledPosition;
        }
    }

    void SaveInitialPositions()
    {
        initialPositions = new Vector3[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            initialPositions[i] = child.localPosition;
        }
    }

    void RestoreInitialPositions()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.localPosition = initialPositions[i];
        }
    }
}
