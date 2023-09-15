using System;
using UnityEngine;
public class Player : ActorBase
{
    [SerializeField] private LayerMask attackHitMask;
        
    private void Awake()
    {
    }

    private void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    protected override void Move()
    {
        Vector3 inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), .0f, Input.GetAxisRaw("Vertical")).normalized;
        transform.Translate(inputVector * (MovementSpeed * Time.deltaTime));
    }

    protected override void Attack()
    {
        EventLeftMouseButtonClicked clickEvent = new EventLeftMouseButtonClicked(attackHitMask);
        Transform target = (Transform)EventManager.InvokeCallback(clickEvent);
        if (target != null)
        {
            target.GetComponent<IDamageable>()?.TakeDamage(2.0f);
        }
    }
}
