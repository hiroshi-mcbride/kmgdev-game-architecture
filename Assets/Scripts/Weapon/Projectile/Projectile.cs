using UnityEngine;
public class Projectile : BasePhysicsActor, IProjectile
{
    
    public Projectile(WeaponData _weaponData)
    {
        Transform mainCamera = Camera.main.transform;
        Actor = GameObject.Instantiate(_weaponData.BulletPrefab);
        Actor.transform.position = mainCamera.position + (mainCamera.forward * 5.0f);
        Actor.transform.rotation = Quaternion.Euler(mainCamera.forward);
        PhysicsBody = Actor.GetComponent<Rigidbody>();
        PhysicsBody.AddForce(Actor.transform.forward * _weaponData.BulletSpeed);
    }
    
    public void Hit()
    {
        
    }

    public override void FixedUpdate(float _fixedDelta)
    {
        
    }
}
