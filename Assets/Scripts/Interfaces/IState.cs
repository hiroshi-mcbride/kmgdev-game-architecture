using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    Scratchpad OwnerData { get; }
    void Enter();
    void Update(float _delta);
    void Exit();
}
