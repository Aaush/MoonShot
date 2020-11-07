using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnDrops : MonoBehaviour
{
    public GameObject item;
    private Transform playerPos;

    private void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppeditem()
    {
        Vector2 playerPosOffset = new Vector2(playerPos.position.x + 3, playerPos.position.y);
        Instantiate(item, playerPosOffset, Quaternion.identity);
    }
}
