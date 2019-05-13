using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButton : MonoBehaviour
{
    public void GetNextLine()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DialogueManager.instance.DequeueDialog();
        }
    }
}
