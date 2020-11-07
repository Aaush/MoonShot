using System.Net;
using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public Animator anim;
    public Transform firepoint;
    public int Damage = 5;

    public bool isShooting = false;
    public void Update()
    { 
        if (Input.GetButtonDown("Fire1"))
        {
            isShooting = true;
            anim.SetBool("isShooting", isShooting);
        }else if (Input.GetButtonUp("Fire1"))
        {
            isShooting = false;
            anim.SetBool("isShooting", false);
        }

         if (Input.GetButtonDown("Fire2") && isShooting == true || Input.GetButtonDown("Fire2") && gameObject.GetComponent<PlayerMovement>().crouch == true)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firepoint.position, firepoint.right);

        if (hitInfo)
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.TakeDamage(Damage);
            }
        }
    }
}
