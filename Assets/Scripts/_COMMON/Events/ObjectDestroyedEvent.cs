public struct ObjectDestroyedEvent
{
    public IUpdateable DestroyedObject;

    public ObjectDestroyedEvent(IUpdateable _destroyedObject)
    {
        DestroyedObject = _destroyedObject;
    }
}
