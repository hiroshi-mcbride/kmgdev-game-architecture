using UnityEngine;

public abstract class BaseActor : IUpdateable
{
    protected GameObject ActorGameObject;
    public abstract void Update(float _delta);

}
