using UnityEngine;

public struct EventLeftMouseButtonClicked : ICallback
{
    public LayerMask PointerHitMask { get; }

    public EventLeftMouseButtonClicked(LayerMask _pointerHitMask)
    {
        PointerHitMask = _pointerHitMask;
    }

}
