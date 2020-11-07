using System.Collections;
using System.Net;
using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public Animator anim;
    public Transform firepoint;
    public Transform secondFirepoint;
    public Transform originalFirepoint;
    public GameObject impacteffect;
    public LineRenderer[] lines;
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
            StartCoroutine(Shoot());
        }

         if (gameObject.GetComponent<PlayerMovement>().crouch == true)
        {
            firepoint.position = secondFirepoint.position;
        }else
        {
            firepoint.position = originalFirepoint.position;
        }
    }

    public IEnumerator Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firepoint.position, firepoint.right);

        if (hitInfo)
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.TakeDamage(Damage);
            }

            Instantiate(impacteffect, hitInfo.point, Quaternion.identity);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i].SetPosition(0, firepoint.position);
                lines[i].SetPosition(1, hitInfo.point); ;
            }
        }
        else
        {
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i].SetPosition(0, firepoint.position);
                lines[i].SetPosition(1, firepoint.position + firepoint.right * 100); ;
            }
        }
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i].enabled = true;
            yield return 0;
            lines[i].enabled = false;
        }
    }
}
