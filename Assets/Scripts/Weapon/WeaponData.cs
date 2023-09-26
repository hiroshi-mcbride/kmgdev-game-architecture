using UnityEngine;

/// <summary>
/// Data object which is intended to be used by the Spawner to initialize a new weapon.
/// </summary>

[CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Objects/Weapon Data", order = 1)]
public class WeaponData : ScriptableObject
{
    [Min(1)]public int Ammo;
    public float Damage;
    [Min(0.01f)]public float FireRate;

    // public Projectile BulletType;
}
