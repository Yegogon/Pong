using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    [Header("Platform Generic Speed")]
    [SerializeField] private float GenericSpeed = 3f;

    Rigidbody2D _platform;

    private void Awake()
    {
        _platform = GetComponent<Rigidbody2D>();
    }

    public void TurnRight()
    {
        _platform.velocity = Vector2.right * GenericSpeed;
    }

    public void TurnLeft()
    {
        _platform.velocity = Vector2.left * GenericSpeed;
    }

    public void StopMovement()
    {
        _platform.velocity = Vector2.zero;
    }

    public void DebugButton()
    {
        Debug.Log("It works!");
    }

    void MissingVoid()
    {
        Debug.LogError("You forgot to set a method!");
    }
}
