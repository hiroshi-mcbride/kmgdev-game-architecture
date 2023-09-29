public struct ObjectCreatedEvent
{
    public IUpdateable CreatedObject { get; }

    public ObjectCreatedEvent(IUpdateable _createdObject)
    {
        CreatedObject = _createdObject;
    }
}
