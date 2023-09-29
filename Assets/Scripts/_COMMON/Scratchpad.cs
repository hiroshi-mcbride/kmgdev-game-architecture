using System;
using System.Collections.Generic;
using UnityEngine;

public class Scratchpad
{
    private Dictionary<Type, object> pad = new Dictionary<Type, object>();

    public void Create(object _data)
    {
        bool keyIsAvailable = pad.TryAdd(_data.GetType(), _data);
        
        if (!keyIsAvailable)
        {
            Debug.LogWarning($"Can't create: Scratchpad already contains entry of type {_data.GetType()}.");
        }
    }
    
    public T Read<T>()
    {
        bool containsValue = pad.TryGetValue(typeof(T), out object value);
        
        if (!containsValue)
        {
            Debug.LogWarning($"Can't read: Scratchpad does not contain entry of type {typeof(T)}. Returning null.");
        }

        return (T)value;
    }

    public void Update(object _data)
    {
        Type type = _data.GetType();
        bool entryExists = pad.ContainsKey(type);
        
        if (entryExists)
        {
            pad[_data.GetType()] = _data;
        }
        else
        {
            Debug.LogWarning($"Can't update: Scratchpad does not contain entry of type {_data.GetType()}.");
        }
    }

    public void Delete(Type _type)
    {
        bool containsType = pad.ContainsKey(_type);
        
        if (containsType)
        {
            pad.Remove(_type);
        }
        else
        {
            Debug.LogWarning($"Can't delete: Scratchpad does not contain entry of type {_type}.");
        }
    }
}
