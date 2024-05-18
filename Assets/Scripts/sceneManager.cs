using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
  
   public void SahneDegistir()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OyunBitti()
    {
        Application.Quit();
        Debug.Log("Oyun Bitti");
    }
}
