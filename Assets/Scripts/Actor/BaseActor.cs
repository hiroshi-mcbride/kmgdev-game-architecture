using UnityEngine;

public abstract class BaseActor : IUpdateable
{
    protected GameObject ActorGameObject;
    public virtual void Create()
    {
        ActorGameObject = new GameObject();
        EventManager.Invoke(new ObjectCreatedEvent(this));
    }

    public abstract void Update(float _delta);

    public virtual void Destroy()
    {
        EventManager.Invoke(new ObjectDestroyedEvent(this));
    }
}
