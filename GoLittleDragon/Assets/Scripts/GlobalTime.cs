using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{
    public GameObject timeDisplay;
    public int seconds = 30;
    public bool deductingTime;
    public GameObject timeUptext;
    public GameObject fadeIn;
    private GameObject thePlayer;

    // Update is called once per frame
    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");

        if (seconds == 0)
        {
            thePlayer.GetComponent<PlayerControls>().enabled = false;
            seconds = 0;
            timeUptext.SetActive(true);
            fadeIn.SetActive(true);
            StartCoroutine(RespawningLevel());
        }
        else
        {
            if(deductingTime == false)
        {
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
        }
    }

    IEnumerator DeductSecond()
    {
        yield return new WaitForSecondsRealtime(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "Time: " + seconds;
        deductingTime = false;
    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(2);
    }
}
