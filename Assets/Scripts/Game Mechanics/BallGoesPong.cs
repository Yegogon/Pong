using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGoesPong : MonoBehaviour
{
    [SerializeField] private float GenericSpeed = 30;

    Rigidbody2D _ball;
    float x;
    float y;

    bool _randomX;
    bool _randomY;

    private void Awake()
    {
        _ball = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StartRound();
    }

    void StartRound()
    {
        _randomX = Random.value > 0.5f;
        _randomY = Random.value > 0.5f;

        if (_randomX)
            x = GenericSpeed;
        else if (!_randomX)
            x = -GenericSpeed;

        if (_randomY)
            y = GenericSpeed;
        else if (!_randomY)
            y = -GenericSpeed;
        _ball.AddForce(new Vector2(x, y));
    }
}
