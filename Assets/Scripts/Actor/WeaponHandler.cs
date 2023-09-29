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
        currentWeapon?.Fire(_delta);
    }
}