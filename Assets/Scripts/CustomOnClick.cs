using UnityEngine;
using System.Collections.Generic;

public class CustomOnClick : MonoBehaviour
{
    public List<GameObject> elementsToToggle = new List<GameObject>();

    private bool isWaitingForClick = false;

    public void WaitForClick()
    {
        if (!isWaitingForClick)
        {
            isWaitingForClick = true;
            Invoke("ToggleElements", 0.1f);
        }
    }

    private void ToggleElements()
    {
        isWaitingForClick = false;
        foreach (GameObject element in elementsToToggle)
        {
            if (element != null)
            {
                element.SetActive(!element.activeSelf);
            }
        }
    }
}
