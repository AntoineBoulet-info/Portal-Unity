using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused =false;

  public GameObject pauseMenuUI;
  public GameObject crossHairUI;
  
  void Update() {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (GameIsPaused)
      {
        Resume();
      }
      else
      {
         Pause();
      }
    }
  }

  public void Resume()
  {
    pauseMenuUI.SetActive(false);
    crossHairUI.SetActive(true);
    GameIsPaused = false;
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;

  }

  void Pause()
  {
    pauseMenuUI.SetActive(true);
    crossHairUI.SetActive(false);
    GameIsPaused =true;
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;

  }

  public void QuitGame()
  {
    Debug.Log ("QUIT!");
    Application.Quit();
  }
}
