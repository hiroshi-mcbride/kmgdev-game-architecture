using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Keeps a reference to the currently equipped weapon and fires it on input
/// </summary>

public class WeaponHandler : IUpdateable
{
    private IWeapon currentWeapon;

    public void Update(float _delta)
    {
        if (currentWeapon == null)
        {
            return;
        }
        currentWeapon.Update(_delta);

        if (currentWeapon.IsAutomatic ? Input.GetMouseButton(0) : Input.GetMouseButtonDown(0))
        {
            currentWeapon.Fire();
        }
    }

    public void EquipWeapon()
    {
        currentWeapon = new Weapon();
    }
}