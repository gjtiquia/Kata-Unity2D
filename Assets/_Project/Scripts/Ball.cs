using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody.velocity = _speed * (Vector2)Random.onUnitSphere;
    }
}
