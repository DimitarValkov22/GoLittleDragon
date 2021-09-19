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
    public AudioSource buttonClick;

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
        buttonClick.Play();
    }

    public void OpenOptionMenu()
    {
        optionsMenu.SetActive(true);
        buttonClick.Play();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(GlobalLevel.levelNumber);
        buttonClick.Play();
    }

    public void LoadGame()
    {
        buttonClick.Play();
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
        buttonClick.Play();
        SceneManager.LoadScene(21);
    }

    public void QuitGame()
    {
        buttonClick.Play();
        Application.Quit();
    }
}
