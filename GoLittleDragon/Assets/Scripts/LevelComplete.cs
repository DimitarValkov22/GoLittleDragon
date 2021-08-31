using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int importedCoins;

    public GameObject completedText;
    public GameObject fadeOut;
    private GameObject thePlayer;

  
    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");

        importedCoins = GlobalCoin.coinCount;
        if(importedCoins == 5)
        {
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(0.2f);
        completedText.SetActive(true);
        fadeOut.SetActive(true);
        thePlayer.GetComponent<PlayerControls>().enabled = false;
        GlobalCoin.coinCount = 0;
        yield return new WaitForSecondsRealtime(3);
        GlobalLevel.levelNumber += 1;
        PlayerPrefs.SetInt("LevelLoadNumber", GlobalLevel.levelNumber);
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
}
