using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguesTrigger : MonoBehaviour
{
    public Dialogue[] dialogue;

    // Allows for the dialogue to be triggered. Should run thought each element of the array. But it only shows the
    // last element in the array.
    public void TriggerDialogue()
    {
        for (int i = 0; i < dialogue.Length; i++)
        {
            FindObjectOfType<DialoguesManager>().StartDialogue(dialogue[i]);
        }
    }
}