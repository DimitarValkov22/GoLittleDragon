using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SphereCollide : MonoBehaviour
{
    public GameObject obstacleText;
    public GameObject fadeOut;
    private GameObject thePlayer;
    public GameObject deathSound;

    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.GetComponent<SphereCollider>().enabled = false;
            deathSound.SetActive(true);
            thePlayer.GetComponent<PlayerControls>().enabled = false;
            thePlayer.GetComponentInChildren<Animator>().enabled = false;
            obstacleText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
        }
    }

    IEnumerator RespawningLevel()
    {
        // yield return new WaitForSecondsRealtime(0.1f);
        //deathSound.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(2);
    }
}
