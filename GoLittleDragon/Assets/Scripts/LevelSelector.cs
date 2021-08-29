using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    void Start()
    {
        GlobalCoin.coinCount = 0;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }
}
