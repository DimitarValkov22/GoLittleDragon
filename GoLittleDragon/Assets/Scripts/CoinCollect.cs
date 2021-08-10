using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public AudioSource collectSound;
     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            collectSound.Play();
            GlobalCoin.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}
