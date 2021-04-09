using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
     public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // sets default to having the menu hidden
    

    void Update()
    {  
        Debug.Log(Input.GetKeyDown(KeyCode.Escape));
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            } else{
                Pause();
            }
        }
    }

    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
