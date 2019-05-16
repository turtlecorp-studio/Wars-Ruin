using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVillage : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.tag = "Player";
        SceneManager.LoadScene("Map");
    }
}
