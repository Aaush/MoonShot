using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    public int IchorCount;
    public int SoulCount;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ichor"))
        {
            IchorCount += 1;
        }
        if (col.gameObject.CompareTag("soul"))
        {
            SoulCount += 1;
        }
    }
}
