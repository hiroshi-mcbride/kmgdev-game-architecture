using System;
using System.Collections.Generic;

public static class EventManager
{
    private static Dictionary<Type, Delegate> eventDictionary = new Dictionary<Type, Delegate>();
    //private static Queue<QueuedEvent> eventQueue = new Queue<QueuedEvent>();
    
    public static void Subscribe(Type _type, Delegate _function)
    {
        eventDictionary.TryAdd(_type, null);
        eventDictionary[_type] = Delegate.Combine(eventDictionary[_type], _function);
    }

    public static void Unsubscribe(Type _type, Delegate _function)
    {
        if (!eventDictionary.ContainsKey(_type) || eventDictionary[_type] == null)
        {
            return;
        }
    
        eventDictionary[_type] = Delegate.Remove(eventDictionary[_type], _function);
    }

    public static void Invoke(IEvent _event)
    {
        if ( !eventDictionary.ContainsKey( _event.GetType() ) )
        {
            return;
        }

        eventDictionary[_event.GetType()]?.DynamicInvoke(_event);
    }

    public static object InvokeCallback(ICallback _event)
    {
        if ( !eventDictionary.ContainsKey( _event.GetType() ) )
        {
            return null;
        }

        return eventDictionary[_event.GetType()]?.DynamicInvoke(_event);
    }
/*
    public static void EnqueueEvent(Type _type, params object[] _args)
    {
        eventQueue.Enqueue(new QueuedEvent(_type, _args));
    }

    public static void ProcessQueuedEvents()
    {
        while (eventQueue.Count > 0)
        {
            QueuedEvent queuedEvent = eventQueue.Dequeue();
            if (eventDictionary.ContainsKey(queuedEvent.EventType) && eventDictionary[queuedEvent.EventType] != null)
            {
                eventDictionary[queuedEvent.EventType]?.Invoke();
            }
        }
    }
    

    private struct QueuedEvent
    {
        public Type EventType;
        public object[] DelegateArgs;

        public QueuedEvent(Type _eventType, params object[] _delegateArgs)
        {
            EventType = _eventType;
            DelegateArgs = _delegateArgs;
        }
    }*/
}
