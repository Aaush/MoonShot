using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnDrops : MonoBehaviour
{
    public GameObject item;
    private GameObject playerPos;

    private void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player");
    }

    public void SpawnDroppeditem()
    {
        Vector2 playerPosOffset = new Vector2(playerPos.transform.position.x + 3 , playerPos.transform.position.y);
        Instantiate(item, playerPosOffset, Quaternion.identity);
    }
}
