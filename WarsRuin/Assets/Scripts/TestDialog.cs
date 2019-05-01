using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialog : MonoBehaviour
{
    public DialogueBase dialogue;
    public GameObject alertIcon;
    public GameObject lightIndicator;
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
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameObject.Find("Camera").GetComponent<ThirdPersonCamera>().enabled = false;
            triggerSound.Play();
            TriggerDialogue();
            Destroy(alertIcon);
           // Destroy(gameObject);
            //Destroy(lightIndicator);
        }
    }

     void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(lightIndicator);
        }
    }



}

