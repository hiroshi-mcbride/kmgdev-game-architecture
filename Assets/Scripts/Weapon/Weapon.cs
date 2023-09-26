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
        
        // subscribe to fire input event?
    }
    
    public void Fire(float _delta)
    {
        fireRateTimer.Run(_delta, out bool isTimerExpired);
        if (isTimerExpired)
        {
            //SimpleProjectile projectile = new SimpleProjectile();
            //projectile.Create();
            Ammo -= 1;
            Debug.Log("Bang!");

            if (Ammo <= 0)
            {
                //EventManager.Invoke(new WeaponOutOfAmmoEvent());
            }
        }
    }
}
