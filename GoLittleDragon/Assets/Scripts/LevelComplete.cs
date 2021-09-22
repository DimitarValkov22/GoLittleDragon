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
    public AudioSource completeSound;

  
    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");

        importedCoins = GlobalCoin.coinCount;
        if(importedCoins == 5)
        {
            thePlayer.GetComponent<PlayerControls>().enabled = false;
            fadeOut.SetActive(true);
            this.GetComponent<GlobalTime>().enabled = false;
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        completeSound.Play();
        yield return new WaitForSecondsRealtime(1);
        Time.timeScale = 0;
        completedText.SetActive(true);
        GlobalCoin.coinCount = 0;
        yield return new WaitForSecondsRealtime(3);
        GlobalLevel.levelNumber += 1;
        PlayerPrefs.SetInt("LevelLoadNumber", GlobalLevel.levelNumber);
        Time.timeScale = 1;
        this.GetComponent<GlobalTime>().enabled = true;
        SceneManager.LoadScene(2);
    }
}
