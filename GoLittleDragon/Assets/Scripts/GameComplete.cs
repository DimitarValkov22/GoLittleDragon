using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public AudioSource buttonClick;

    public void MainMenuu()
    {
        buttonClick.Play();
        SceneManager.LoadScene(1);
    }

    public void ExitTheGame()
    {
        buttonClick.Play();
        Application.Quit();
    }
}
