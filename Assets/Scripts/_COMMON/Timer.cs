using UnityEngine;

public class Timer
{
    private float length;
    private float currentTime;

    public Timer(float _length)
    {
        length = _length;
    }

    public void Run(float _delta, out bool _expired)
    {
        if (currentTime >= length)
        {
            _expired = true;
            currentTime = .0f;
            return;
        }
        currentTime += _delta;
        _expired = false;
    }
}
