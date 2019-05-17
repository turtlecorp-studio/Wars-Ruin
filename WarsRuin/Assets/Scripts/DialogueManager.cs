using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject dialogueBox;

    public Text dialogueName;
    public Text dialogueText;
    public Image dialoguePortrait;
    public Image npcPortrait;
    public float delay = 0.001f;

    public Queue<DialogueBase.Info> dialogueInfo = new Queue<DialogueBase.Info>(); //FIFO Collection

     void Update()
    {
        ToggleDialogue();
    }

    public void EnqueueDialogue(DialogueBase db)
    {
        dialogueBox.SetActive(true);
        dialogueInfo.Clear();
  
        

        foreach(DialogueBase.Info info in db.dialogueInfo)
        {
            dialogueInfo.Enqueue(info);
        }

        DequeueDialog();
    }

    public void DequeueDialog()
    {
        if(dialogueInfo.Count == 0)
        {
            EndOfDialogue();
            return;
        }

        DialogueBase.Info info = dialogueInfo.Dequeue();
        dialogueName.text = info.myName;
        dialogueText.text = info.myText;
        dialoguePortrait.sprite = info.portrait;
        npcPortrait.sprite = info.otherPortraits;



        StartCoroutine(TypeText(info));

    }


    IEnumerator TypeText(DialogueBase.Info info)
    {
        dialogueText.text = "";
        foreach(char c in info.myText.ToCharArray())
        {
            yield return new WaitForSeconds(delay);
            dialogueText.text += c;
            yield return null;
        }
    }

    public void EndOfDialogue()
    {
        dialogueBox.SetActive(false);
    }

    public void ToggleDialogue()
    {
        if (dialogueBox.activeSelf == true)
        {
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
        } else if (dialogueBox.activeSelf == false)
        {
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        }
    }
}
