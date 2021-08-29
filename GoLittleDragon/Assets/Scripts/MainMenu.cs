using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int loadLevel;

    public void StartGame()
    {
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    public void LoadGame()
    {
        loadLevel = PlayerPrefs.GetInt("LevelLoadNumber");
        if(loadLevel < 3)
        {
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else
        {
            GlobalLevel.levelNumber = loadLevel;
            SceneManager.LoadScene(loadLevel);
        }
    }

    public void SelectCharacter()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
