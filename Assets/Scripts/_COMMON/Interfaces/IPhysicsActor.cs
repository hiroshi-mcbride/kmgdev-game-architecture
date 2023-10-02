using UnityEngine;

public interface IPhysicsActor : IActor
{
    Rigidbody PhysicsBody { get; }
}
