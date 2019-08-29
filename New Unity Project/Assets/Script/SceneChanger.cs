using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject pauseCanvas;


    public void ExitGame()
    {
        Application.Quit();
    }
  
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Pause()
    {
        if (pauseCanvas.activeSelf)
        {
            pauseCanvas.SetActive(false);
            Time.timeScale = 1;

        }
        else if(!pauseCanvas.activeSelf)
        {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0;
        }
               
      
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            Pause();
       }  
   
    }
}
