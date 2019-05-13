using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialoguesManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public Sprite Actor;
    public Image Portraits;
    public Image imageSpot;


    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        Debug.Log("Starting conversation with " + dialogue.name);

        Actor.sprite = dialogue.actor;
        imageSpot.sprite = dialogue.actor;
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

      void DisplayNextSentence () { 
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
      
        Debug.Log("End of Conversation.");

        Cursor.visible = false;
    }

}

    }
