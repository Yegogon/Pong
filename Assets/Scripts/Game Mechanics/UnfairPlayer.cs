using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnfairPlayer : MonoBehaviour
{
    [Header("Platform Generic Speed")]
    [SerializeField] private float GenericSpeed = 3f;

    [Header("Pong Ball Instance")]
    [SerializeField] private GameObject BallInstance;

    Rigidbody2D _platform;
    Transform _currentPosition;

    private void Awake()
    {
        _platform = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _currentPosition = GetComponent<Transform>();

        Wait();

        if (BallInstance.transform.position.x != _currentPosition.position.x)
        {
            if (BallInstance.transform.position.x > _currentPosition.position.x)
            {
                TurnRight();
            }
            else if (BallInstance.transform.position.x < _currentPosition.position.x)
            {
                TurnLeft();
            }
            else
            {
                StopMovement();
            }
        }
        else
        {
            StopMovement();
        }
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

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }
}
