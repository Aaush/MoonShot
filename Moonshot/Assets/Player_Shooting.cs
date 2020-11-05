using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.Mathematics;
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

    }
}
