using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [Header("UI reference")]
    [SerializeField] private GameObject PauseScreen;
    [SerializeField] private GameObject Background;

    bool _toggle = false;

    public void Pause()
    {
        if (!_toggle)
        {
            _toggle = true;
            Time.timeScale = 0f;
            PauseScreen.SetActive(true);
            Background.SetActive(true);
        }
        else if (_toggle)
        {
            _toggle = false;
            Time.timeScale = 1f;
            PauseScreen.SetActive(false);
            Background.SetActive(false);
        }
    }
}
