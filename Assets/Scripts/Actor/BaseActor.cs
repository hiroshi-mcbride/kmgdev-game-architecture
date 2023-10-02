using UnityEngine;
using System.Collections;

/// <summary>
/// Base type for any object in the scene that can run logic each frame
/// </summary>
public abstract class BaseActor : IActor, IUpdateable
{
    public GameObject Actor { get; protected set; }

    public abstract void Update(float _delta);
}
