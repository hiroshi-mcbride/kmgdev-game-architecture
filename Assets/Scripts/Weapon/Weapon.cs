using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : IWeapon
{
    public bool IsAutomatic { get; }
    private int ammo;
    private float damage;
    private float fireRate;
    private Timer fireRateTimer;
    private bool canFire;

    public Weapon(WeaponData _weaponData)
    {
        ammo = _weaponData.Ammo;
        damage = _weaponData.Damage;
        fireRate = _weaponData.FireRate;
        IsAutomatic = _weaponData.IsAutomatic;
        fireRateTimer = new Timer(1/fireRate);
    }


    public void Fire()
    {
        if (canFire)
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

    public void RunFireRateTimer(float _delta)
    {
        fireRateTimer.Run(_delta, out canFire);
    }
}
