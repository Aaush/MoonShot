using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int powerNeeded = 20;
    public float currentPower;

    public float distToPlayer;
    public float Ichor;

    public GameObject UpgradeButton;
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPower >= powerNeeded)
        {
            LaunchSatellite();
        }
        distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer <= 3.5)
        {
            UpgradeButton.SetActive(true);
        }
        else
        {
            UpgradeButton.SetActive(false);
        }
    }

    public void takeIchor()
    {
       //check if player inventory has ichor
       if (Ichor >= 0 && distToPlayer <= 3.5)
        {
            Debug.Log("taking " + Ichor + " ichor");
            currentPower += Ichor;
            Ichor -= Ichor;
        }
    }
    public void LaunchSatellite()
    {
        //show animation to launch a sattelite
        Debug.Log("Launcing sattelite");
    }

    public void UpgradeGear()
    { 
    }
}
