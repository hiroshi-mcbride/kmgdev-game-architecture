using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : IWeapon
{
    private int ammo;
    private float damage;
    private float fireRate;
    private Timer fireRateTimer;

    public Weapon(WeaponData _weaponData)
    {
        ammo = _weaponData.Ammo;
        damage = _weaponData.Damage;
        fireRate = _weaponData.FireRate;
        fireRateTimer = new Timer(1/fireRate);
    }
    
    public void Fire(float _delta)
    {
        fireRateTimer.Run(_delta, out bool isTimerExpired);
        if (isTimerExpired)
        {
            //SimpleProjectile projectile = new SimpleProjectile();
            //projectile.Create();
            ammo -= 1;
            Debug.Log("Bang!");

            if (ammo <= 0)
            {
                //EventManager.Invoke(new WeaponOutOfAmmoEvent());
            }
        }
    }
}
