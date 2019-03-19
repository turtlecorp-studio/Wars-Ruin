using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public static DialogueManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("fix this" + gameObject.name);
        }
        else
        {
            instance = this;
        }
    }

    public Text dialogueName;
    public Text dialogueText;
    public Image dialoguePortrait;

    public Queue<DialogueBase.Info> dialogueInfo = new Queue<DialogueBase.Info>(); //FIFO Collection

    public void EnqueueDialogue(DialogueBase db)
    {
        dialogueInfo.Clear();

        foreach(DialogueBase.Info info in db.dialogueInfo)
        {
            dialogueInfo.Enqueue(info);
        }

        DequeueDialog();
    }

    public void DequeueDialog()
    {
        DialogueBase.Info info = dialogueInfo.Dequeue();
        dialogueName.text = info.myName;
        dialogueText.text = info.myText;
        dialoguePortrait.sprite = info.portrait;

    }
}
