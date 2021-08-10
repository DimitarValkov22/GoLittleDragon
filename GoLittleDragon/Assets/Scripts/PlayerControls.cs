using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public GameObject realPlayer;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            realPlayer.transform.localRotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed * -1);
            realPlayer.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            realPlayer.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * -1);
            realPlayer.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            realPlayer.transform.localRotation = Quaternion.Euler(0, 45, 0);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            realPlayer.transform.localRotation = Quaternion.Euler(0, 135, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            realPlayer.transform.localRotation = Quaternion.Euler(0, 225, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            realPlayer.transform.localRotation = Quaternion.Euler(0, 315, 0);
        }
    }
}
