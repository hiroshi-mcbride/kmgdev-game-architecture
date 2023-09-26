using UnityEngine;

public struct MousePointerQueryEvent
{
    public LayerMask PointerHitMask { get; }
    
    public MousePointerQueryEvent(LayerMask _pointerHitMask)
    {
        PointerHitMask = _pointerHitMask;
    }
}
