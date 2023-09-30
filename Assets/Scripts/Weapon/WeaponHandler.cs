using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler
{
    private IWeapon currentWeapon;


    public WeaponHandler()
    {
    }

    public void Update(float _delta)
    {
        if (currentWeapon == null)
        {
            return;
        }
        currentWeapon.RunFireRateTimer(_delta);

        if (currentWeapon.IsAutomatic ? Input.GetMouseButton(0) : Input.GetMouseButtonDown(0))
        {
            currentWeapon.Fire();
        }
    }
}