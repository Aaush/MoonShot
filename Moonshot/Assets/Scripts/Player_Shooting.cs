using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public Animator anim;

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

         if (Input.GetButtonDown("Fire2") && isShooting == true)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        //raycast
    }
}
