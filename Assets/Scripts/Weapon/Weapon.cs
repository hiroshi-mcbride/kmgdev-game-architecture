using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : IWeapon
{
    public int Ammo { get; private set; }
    public float Damage { get; }
    public float FireRate { get; }

    private Timer fireRateTimer;

    public Weapon(WeaponData _weaponData)
    {
        Ammo = _weaponData.Ammo;
        Damage = _weaponData.Damage;
        FireRate = _weaponData.FireRate;
        fireRateTimer = new Timer(1/FireRate);
    }
    
    public void Fire(float _delta)
    {
        fireRateTimer.Run(_delta, out bool isTimerExpired);
        if (isTimerExpired)
        {
            // TODO: spawn projectile
            Ammo -= 1;
            Debug.Log("Bang!");

            if (Ammo <= 0)
            {
                //EventManager.Invoke(new WeaponOutOfAmmoEvent());
            }
        }
    }
}
