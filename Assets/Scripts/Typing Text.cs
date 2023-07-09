using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class TypingEffect : MonoBehaviour
{
    public float typingSpeed = 0.1f; 
    public string fullText = "Texto completo a mostrar";
    private string currentText = "";

    private void Start()
    {
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            GetComponent<TextMeshProUGUI>().text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
