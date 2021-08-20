using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject secondPlayer;
    public GameObject thirdPlayer;

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        transform.LookAt(secondPlayer.transform);
        transform.LookAt(thirdPlayer.transform);
    }
}
