using UnityEngine;

public class ActivateAndExecuteScript : MonoBehaviour
{
    public MonoBehaviour scriptToActivate;
    public MonoBehaviour scriptToExecute;
    public float delay = 6f;

    void Start()
    {
        Invoke("ActivateAndExecute", delay);
    }

    void ActivateAndExecute()
    {
        if (scriptToActivate != null)
        {
            if (!scriptToActivate.enabled)
                scriptToActivate.enabled = true;
        }

        if (scriptToExecute != null)
        {
            if (!scriptToExecute.enabled)
                scriptToExecute.enabled = true;

           
            scriptToExecute.SendMessage("MethodName", SendMessageOptions.DontRequireReceiver);
        }
    }
}