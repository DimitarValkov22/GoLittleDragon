using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoin : MonoBehaviour
{
    public GameObject textScore;
    public static int coinCount;

    void Update()
    {
        textScore.GetComponent<Text>().text = "Score: " + coinCount;
    }
}
