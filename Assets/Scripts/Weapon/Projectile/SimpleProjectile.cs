using UnityEngine;
public class SimpleProjectile : BaseActor, IProjectile
{
    public SimpleProjectile()
    {
        var rigidbody = Actor.GetComponent<Rigidbody>();
        rigidbody.AddForce(rigidbody.transform.forward * 60.0f);
    }

    public override void Update(float _delta)
    {
    }

    public void Hit()
    {
        
    }
}
