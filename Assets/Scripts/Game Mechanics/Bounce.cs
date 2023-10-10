using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] AudioSource BounceSource;
    [SerializeField] float Acceleration = 0.1f;

    Rigidbody2D _rb;
    Vector3 _lastVelocity;
    SoundWire wireOutput;

    private void Awake()
    {
        wireOutput = new SoundWire();
        _rb = GetComponent<Rigidbody2D>();
        //BounceSource.volume = wireOutput.SFXWire / 100f;
    }

    private void FixedUpdate()
    {
        _lastVelocity = _rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = _lastVelocity.magnitude;
        var direction = Vector3.Reflect(_lastVelocity.normalized, collision.contacts[0].normal);
        _rb.velocity = direction * Mathf.Max(speed + Acceleration, 0f);
        BounceSource.Play();
    }
}
