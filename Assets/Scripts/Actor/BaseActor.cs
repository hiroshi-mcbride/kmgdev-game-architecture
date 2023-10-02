using UnityEngine;
using System.Collections;

/// <summary>
/// Base type for any object in the scene that can run some kind of logic each frame
/// </summary>
public abstract class BaseActor : IActor
{
    public GameObject Actor { get; protected set; }

    public abstract void Update(float _delta);
}
