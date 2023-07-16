using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void FixedUpdate()
    {
        Vector2 targetVelocity = Vector2.zero;

        if (Input.GetKey(KeyCode.D))
        {
            targetVelocity.x += _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            targetVelocity.x -= _speed;
        }

        _rigidbody.velocity = targetVelocity;
    }
}
