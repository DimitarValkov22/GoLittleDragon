using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastLevelCompleted : MonoBehaviour
{
    public int importedCoins;

    public GameObject completedText;
    public GameObject fadeOut;
    private GameObject thePlayer;


    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");

        importedCoins = GlobalCoin.coinCount;
        if (importedCoins == 5)
        {
            fadeOut.SetActive(true);
            this.GetComponent<GlobalTime>().enabled = false;
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        yield return new WaitForSecondsRealtime(1);
        Time.timeScale = 0;
        completedText.SetActive(true);
        thePlayer.GetComponent<PlayerControls>().enabled = false;
        GlobalCoin.coinCount = 0;
        yield return new WaitForSecondsRealtime(3);
        GlobalLevel.levelNumber += 1;
        PlayerPrefs.SetInt("LevelLoadNumber", GlobalLevel.levelNumber);
        Time.timeScale = 1;
        this.GetComponent<GlobalTime>().enabled = true;
        SceneManager.LoadScene(20);
    }
}
