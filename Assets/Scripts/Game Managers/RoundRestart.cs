using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoundRestart : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] private float GenericSpeed = 30;
    [Header("Button References")]
    [SerializeField] private GameObject ButtonPlayer1LeftSide;
    [SerializeField] private GameObject ButtonPlayer1RightSide;
    [SerializeField] private GameObject ButtonPlayer2LeftSide;
    [SerializeField] private GameObject ButtonPlayer2RightSide;
    [Header("SFX")]
    [SerializeField] AudioSource GoalSound;
    [Header("Game Over Text")]
    [SerializeField] GameObject GameOverText1;
    [SerializeField] GameObject GameOverText2;

    ScoreManager scoreManager;
    Transform _position;
    Rigidbody2D _ball;
    PauseGame _endGame;


    float x;
    float y;

    bool _randomX;
    bool _randomY;

    private void Awake()
    {
        _position = GetComponent<Transform>();
        _ball = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<ScoreManager>();

        scoreManager.Points1 = PlayerPrefs.GetInt("Points1", 0);
        scoreManager.Points2 = PlayerPrefs.GetInt("Points1", 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoalSound.Play();
        _position.position = new Vector2(0f, 0f);
        _ball.velocity = Vector2.zero;
       
        if (collision.name == "Catcher1")
            scoreManager.Points1++;
        else if (collision.name == "Catcher2")
            scoreManager.Points2++;
        

        StartRound();
        if (scoreManager.Points1 >= 15 || scoreManager.Points2 >= 15)
        {
            Time.timeScale = 0f;
            DisableButtons();
            _endGame.Pause();
            GameOverText1.SetActive(true);
            GameOverText2.SetActive(true);
        }
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

    void DisableButtons()
    {
        ButtonPlayer1LeftSide.SetActive(false);
        ButtonPlayer1RightSide.SetActive(false);
        ButtonPlayer2LeftSide.SetActive(false);
        ButtonPlayer2RightSide.SetActive(false);
    }
}
