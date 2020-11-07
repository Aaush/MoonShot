using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int powerNeeded = 20;
    public float currentPower;

    public float distToPlayer;

    public GameObject Player;

    public GameObject UpgradeButton;
    public Transform playerPos;
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
        distToPlayer = Vector2.Distance(transform.position, playerPos.position);

        if (distToPlayer <= 3.5)
        {
            UpgradeButton.SetActive(true);
        }
        else
        {
            UpgradeButton.SetActive(false);
        }

        if (distToPlayer <= 3.5 && Player.GetComponent<PlayerInventory>().IchorCount > 0)
        {
            takeIchor();
        }
    }

    public void takeIchor()
    {
            Debug.Log("taking " + Player.GetComponent<PlayerInventory>().IchorCount + " ichor");
            currentPower += Player.GetComponent<PlayerInventory>().IchorCount;
            Player.GetComponent<PlayerInventory>().IchorCount = 0;
        
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
