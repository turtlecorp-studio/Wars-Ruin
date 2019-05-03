using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialog : MonoBehaviour
{
    //public GameObject dialoguePanel;
    public DialogueBase dialogue;
    public GameObject alertIcon;
    public GameObject lightIndicator;
    public AudioSource triggerSound;

    void Start()
    {
        //dialoguePanel = GameObject.FindGameObjectWithTag("DialoguePanel");
    }
    public void TriggerDialogue()
    {
        DialogueManager.instance.EnqueueDialogue(dialogue);
    }

    
         
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("space") && other.tag == "Player")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //GameObject.Find("Camera").GetComponent<ThirdPersonCamera>().enabled = false;
           // GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
            triggerSound.Play();
            TriggerDialogue();
            Destroy(alertIcon);

        } /*else if (GameObject.Find("DialoguePanel").activeSelf == false)
        {
            GameObject.Find("Camera").GetComponent<ThirdPersonCamera>().enabled = true;
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        } */
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

