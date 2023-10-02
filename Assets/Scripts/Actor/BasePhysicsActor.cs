using UnityEngine;

/// <summary>
/// Base type for any object in the scene with physics properties that can run physics logic each frame
/// </summary>
public abstract class BasePhysicsActor : IPhysicsActor, IFixedUpdateable
{
    public GameObject Actor { get; protected set; }
    public Rigidbody PhysicsBody { get; protected set; }

    public abstract void FixedUpdate(float _fixedDelta);
}
