using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : BaseActor, IWeapon
{
    public bool IsAutomatic { get; }
    private int ammo;
    private float damage;
    private Timer fireRateTimer;
    private bool canFire = true;

    public Weapon()
    {
        var weaponData = Resources.Load<WeaponData>("PistolData");
        Actor = GameObject.Instantiate(weaponData.Model, Camera.main.transform);
        Actor.transform.localPosition = new Vector3(.8f, -0.7f, 1.7f);
        Actor.transform.localRotation = Quaternion.Euler(.0f, -90.0f, .0f);
        ammo = weaponData.Ammo;
        damage = weaponData.Damage;
        IsAutomatic = weaponData.IsAutomatic;
        Action enableFire = () => canFire = true;
        fireRateTimer = new Timer(1 / weaponData.FireRate, enableFire, false);
    }


    public void Fire()
    {
        if (!canFire)
        {
            return;
        }
        
        //SimpleProjectile projectile = new SimpleProjectile();
        ammo -= 1;
        Debug.Log("Bang!");
        fireRateTimer.Start();
        canFire = false;

        if (ammo <= 0)
        {
            //EventManager.Invoke(new WeaponOutOfAmmoEvent());
            
        }
    }

    public override void Update(float _delta)
    {
        fireRateTimer.Update(_delta);
    }
}
