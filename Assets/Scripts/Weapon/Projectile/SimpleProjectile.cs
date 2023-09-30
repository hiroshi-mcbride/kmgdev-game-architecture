using UnityEngine;

public class SimpleProjectile : BaseActor, IProjectile
{
    public SimpleProjectile()
    {
        
        // instead of adding each component separately, maybe read everything from a ScriptableObject
        ActorGameObject.AddComponent<Rigidbody>();
    }

    public override void Update(float _delta)
    {
        
    }

    public void Hit()
    {
        
    }
}
