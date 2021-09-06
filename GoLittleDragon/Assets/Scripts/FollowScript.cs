using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    private GameObject thePlayer;
    public float followspeed;
    public float minDistance;


    void Update()
    {
        thePlayer = GameObject.Find("Player(Clone)");
    }

    void LateUpdate()
    {
        if (thePlayer != null)
        {
            this.transform.LookAt(thePlayer.transform.position);

            if (Vector3.Distance(this.transform.position, thePlayer.transform.position) > minDistance)
            {
                this.transform.Translate(0f, 0f, followspeed * Time.deltaTime);
            }
        }
    }
}