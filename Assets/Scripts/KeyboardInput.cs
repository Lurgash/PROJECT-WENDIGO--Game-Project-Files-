using UnityEngine;
using System.Collections.Generic;

public class KeyboardInput : MonoBehaviour
{
    public KeyCode activationKey;
    public List<GameObject> elementsToToggle = new List<GameObject>();

    void Update()
    {
        if (Input.GetKeyDown(activationKey))
        {
            ToggleElements();
        }
    }

    void ToggleElements()
    {
        foreach (GameObject element in elementsToToggle)
        {
            element.SetActive(!element.activeSelf);
        }
    }
}
