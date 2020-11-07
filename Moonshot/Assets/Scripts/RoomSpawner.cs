using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public GameObject Room;
    void Start()
    {
        Instantiate(Room, gameObject.transform.position, Quaternion.identity);
    }
}
