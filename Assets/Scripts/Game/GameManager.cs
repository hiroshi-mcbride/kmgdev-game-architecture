using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IStateRunner
{
    public Scratchpad ObjectData { get; private set; }

    private StateMachine fsm;

    private void Awake()
    {
        ObjectData = new Scratchpad();
        
        fsm = new StateMachine(this);
        fsm.AddState(new PlayState(ObjectData, fsm));
        fsm.SwitchState(typeof(PlayState));
    }

    private void Update()
    {
        fsm.Update(Time.deltaTime);
    }

    private void FixedUpdate()
    {
        fsm.FixedUpdate(Time.fixedDeltaTime);
    }
}
