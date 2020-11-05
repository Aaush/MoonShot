using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class EnemyLoot : MonoBehaviour
{
    public List<GameObject> loot;
    public int[] lootTable = { 60, 30, 10 };

    public int total;
    public int randomNumber;
    private void Awake()
    {
        foreach (var item in lootTable)
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);
        Debug.Log(  randomNumber );

        for (int i = 0; i < lootTable.Length; i++)
        {
            if (randomNumber <= lootTable[i])
            {
                loot[i].SetActive(true);
            }
            else
            {
                randomNumber -= lootTable[i];
            }
        }
    }
}
