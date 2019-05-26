using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Image leftNameText;
    public Image rightNameText;
    public Text dialogText;
    public Image playerPortrait;
    public Image npcPortrait;

    public Animator animator;
    
    private Queue<string> sentences; //First in first out

    void Start()
    {
        sentences = new Queue<string>();
    }
    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialog(Dialog dialog)
    {
        animator.SetBool("isOpen", true);

        playerPortrait.sprite = dialog.playerPortrait;
        npcPortrait.sprite = dialog.npcPortrait;
        leftNameText.sprite = dialog.leftName;
        rightNameText.sprite = dialog.rightName;

        GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        Debug.Log("End of convo.");
    }
    
}
