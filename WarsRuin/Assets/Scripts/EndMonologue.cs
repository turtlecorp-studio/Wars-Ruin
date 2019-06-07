using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMonologue : MonoBehaviour
{
    public DialogTrigger triggerScript;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerScript.TriggerDialog();
        }
    }
}
