using UnityEngine;
using System;
using System.IO;

public class UserInformation : MonoBehaviour
{
    void Start()
    {
        string username = Environment.UserName;
        string message = "You are not safe, they are hunters. You, " + username + ", are the prey.";
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "warning.txt");
        File.WriteAllText(filePath, message);
    }
}
