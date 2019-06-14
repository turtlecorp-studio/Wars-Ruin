using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMission : MonoBehaviour
{
  public GameObject previousAlert;
  public GameObject endAlert;
  public GameObject vandalFound;
  public Animation transitionAnim;
  
   void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      Destroy(previousAlert);
      endAlert.SetActive(true);
      vandalFound.SetActive(true);
    }
  }

  void TransitionToEnd()
  {
    if (vandalFound == null)
    {
      transitionAnim.Play();
      SceneManager.LoadScene("GameEnding");
    }
  }
}
