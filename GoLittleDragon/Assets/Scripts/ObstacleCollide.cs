using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObstacleCollide : MonoBehaviour
{
    public GameObject obstacleText;
    public GameObject fadeOut;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            thePlayer.GetComponent<PlayerControls>().enabled = false;
            obstacleText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
        }
    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(2);
    }
}
