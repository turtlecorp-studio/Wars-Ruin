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

    public void ContinueToGame()
    {
        SceneManager.LoadScene(2);
    }



    void Update()
   {
    
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.P))
        {
            Application.Quit();
            Debug.Log("Quitting game");
        }
   }
}


