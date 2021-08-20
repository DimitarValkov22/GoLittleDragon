﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int importedCoins;

    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject thePlayer;

  
    void Update()
    {
        importedCoins = GlobalCoin.coinCount;
        if(importedCoins == 5)
        {
            completedText.SetActive(true);
            fadeOut.SetActive(true);
            thePlayer.GetComponent<PlayerControls>().enabled = false;
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        yield return new WaitForSecondsRealtime(3);
    }
}