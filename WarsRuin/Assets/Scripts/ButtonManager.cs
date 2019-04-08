using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

   public void ExitGame()
    {
        Application.Quit();
    }

    void Update()
   {
      if (Input.GetKeyDown(KeyCode.Return))
      {
          SceneManager.LoadScene(2);
      }
   }


}
