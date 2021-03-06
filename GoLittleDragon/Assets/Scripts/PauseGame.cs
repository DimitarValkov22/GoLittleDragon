using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public AudioSource buttonClick;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                this.GetComponent<AudioSource>().UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void UnpauseGame()
    {
        buttonClick.Play();
        pauseMenu.SetActive(false);
        this.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        GlobalCoin.coinCount = 0;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    public void ExitLevel()
    {
        GlobalCoin.coinCount = 0;
        buttonClick.Play();
        Time.timeScale = 1;
        GlobalLevel.levelNumber = 3;
        SceneManager.LoadScene(1);
    }
}
