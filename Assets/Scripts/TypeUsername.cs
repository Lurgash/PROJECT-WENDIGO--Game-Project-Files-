using UnityEngine;
using TMPro;
using System;
using System.Collections;

public class TypeUsername : MonoBehaviour
{
    public TMP_Text textField;

    private void Start()
    {
        StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        string username = Environment.UserName;

        string question = "Do I look beautiful " + username + "?";

        foreach (char letter in question)
        {
            textField.text += letter;
            yield return new WaitForSeconds(0.1f); // Pausa entre cada letra (ajusta el valor según tu preferencia)
        }
    }
}
