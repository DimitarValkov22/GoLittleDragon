using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    private GameObject thePlayer;

    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");
        transform.LookAt(thePlayer.transform);
    }
}
