using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PongPlatformMovement : MonoBehaviour
{
    [Header("Controls")]
    [SerializeField] private KeyCode A = KeyCode.A;
    [SerializeField] private KeyCode D = KeyCode.D;
    [Header("Or")]
    [SerializeField] private KeyCode LeftArrow = KeyCode.LeftArrow;
    [SerializeField] private KeyCode RightArrow = KeyCode.RightArrow;
    [Header("Manage Controls:")]
    [Tooltip("When toggled, the platform controls will be \"A\" and \"D\"")]
    [SerializeField] private bool ToggleForLetters = false;
    [Header("Platform Generic Speed")]
    [SerializeField] private float GenericSpeed = 3f;

    Rigidbody2D _platform;

    private void Awake()
    {
        _platform = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (!ToggleForLetters)
        {
            if (Input.GetKey(RightArrow))
                TurnRight();
            else if (!Input.GetKey(RightArrow))
                StopMovement();

            if (Input.GetKey(LeftArrow))
                TurnLeft();
            else if (!Input.GetKey(LeftArrow))
                StopMovement();
        }
        else
        {
            if (Input.GetKey(D))
                TurnRight();
            else if (!Input.GetKey(RightArrow))
                StopMovement();

            if (Input.GetKey(A))
                TurnLeft();
            else if (!Input.GetKey(LeftArrow))
                StopMovement();
        }
    }

    public void TurnRight()
    {
        _platform.velocity += Vector2.right * GenericSpeed;
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
