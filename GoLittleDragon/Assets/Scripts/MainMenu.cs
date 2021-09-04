using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int loadLevel;
    public GameObject hintBox;
    public int hintNumber;

    public GameObject optionsMenu;

     void Start()
    {
        hintNumber = Random.Range(1, 3);
        if(hintNumber == 1)
        {
            hintBox.GetComponent<Text>().text = "Tips: Collect all coins to complete the level";
        }

        hintNumber = Random.Range(1, 3);
        if (hintNumber == 1)
        {
            hintBox.GetComponent<Text>().text = "Tips: Dont't let the timer hits zero";
        }

        hintNumber = Random.Range(1, 3);
        if (hintNumber == 1)
        {
            hintBox.GetComponent<Text>().text = "Tips: Avoid the walls and the dark 'things'";
        }
    }

    public void CloseOptionMenu()
    {
        optionsMenu.SetActive(false);
    }

    public void OpenOptionMenu()
    {
        optionsMenu.SetActive(true);
    }

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
        SceneManager.LoadScene(13);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
