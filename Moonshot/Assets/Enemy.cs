using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemyHealth = 100f;
    public float CurrentEnemyHealth;

    public GameObject death_fx;
    public GameObject lootDrop;

    private void Start()
    {
        CurrentEnemyHealth = EnemyHealth;
    }
    private void Update()
    {
        if (CurrentEnemyHealth <= 0)
        {
            Die();
        }
    }
    public void TakeDamage(int damage)
    {
        CurrentEnemyHealth -= damage;
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(death_fx, transform.position, quaternion.identity);
        Instantiate(lootDrop, transform.position, transform.rotation);
    }
}
