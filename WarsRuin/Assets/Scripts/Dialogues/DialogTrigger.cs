using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TriggerDialog();
        }
    }

    private void TriggerDialog()
    {
        
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
