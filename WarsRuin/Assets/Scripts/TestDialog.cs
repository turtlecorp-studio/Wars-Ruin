using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialog : MonoBehaviour
{
    public DialogueBase dialogue;
    public AudioSource triggerSound;

    public void TriggerDialogue()
    {
        DialogueManager.instance.EnqueueDialogue(dialogue);
    }

    /* private void Update()
     {

         if(Input.GetKeyDown(KeyCode.Space))
         {
             TriggerDialogue();
         }
     } */

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("space") && other.tag == "Player")
        {
            triggerSound.Play();
            TriggerDialogue();
        }
    }

  

    }

