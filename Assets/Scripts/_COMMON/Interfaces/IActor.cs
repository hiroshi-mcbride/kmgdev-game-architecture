using UnityEngine;

public interface IActor : IUpdateable
{
    public GameObject Actor { get; }
}
