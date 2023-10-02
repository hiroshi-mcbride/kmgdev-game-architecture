using System;
using UnityEngine;

public class Timer : IUpdateable
{
    private float length;
    private float currentTime;
    private bool loop;
    private bool isStarted;
    private Delegate onExpired;

    public Timer(float _length, Delegate _onExpired, bool _startImmediately = true, bool _loop = false)
    {
        length = _length;
        onExpired = _onExpired;
        isStarted = _startImmediately;
        loop = _loop;
    }
    
    public void Update(float _delta)
    {
        if (isStarted)
        {
            RunTimer(_delta);
        }
    }

    public void Start() => isStarted = true;

    private void RunTimer(float _delta)
    {
        if (currentTime < length)
        {
            currentTime += _delta;
        }
        else
        {
            if (!loop) isStarted = false;
            currentTime = .0f;
            onExpired.DynamicInvoke();
        }
    }

}
