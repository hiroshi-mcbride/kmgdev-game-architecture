using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scratchpad
{
    private Dictionary<Type, object> data = new Dictionary<Type, object>();

    public object Read(Type _type)
    {
        bool containsValue = data.TryGetValue(_type, out object value);
        if (!containsValue)
        {
            Debug.LogWarning($"Scratchpad does not contain entry of type {_type}. Ensure null safety.");
        }

        return value;
    }

    public void Write(object _data, bool _overwrite = true)
    {
        bool keyIsAvailable = data.TryAdd(_data.GetType(), _data);
        if (!keyIsAvailable)
        {
            Debug.LogWarning($"Scratchpad already contains entry of type {_data.GetType()}.");
            if (_overwrite) data[_data.GetType()] = _data;
        }
    }
}
