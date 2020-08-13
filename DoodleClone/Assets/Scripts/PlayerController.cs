using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private float _horizontal;

    [SerializeField]
    private float HorizontalForce = 2f;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        var velocity = _rigidBody2D.velocity;
        velocity.x = _horizontal * HorizontalForce;
        _rigidBody2D.velocity = velocity;
    }
}
