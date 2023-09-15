using System;
using UnityEngine;

public class ScreenToWorldspacePointer : MonoBehaviour
{
    private Camera mainCamera;
    private Func<LayerMask, Transform> onClickEventHandler;

    private void Awake()
    {
        onClickEventHandler = QueryPointerHit;
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        EventManager.Subscribe(typeof(EventLeftMouseButtonClicked), onClickEventHandler);
    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(typeof(EventLeftMouseButtonClicked), onClickEventHandler);
    }

    private Transform QueryPointerHit(LayerMask _pointerHitMask)
    {
        Ray cameraPointRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(cameraPointRay, out RaycastHit pointerHit, 99.0f, _pointerHitMask))
        {
            return pointerHit.transform;
        }

        return null;
    }
}
