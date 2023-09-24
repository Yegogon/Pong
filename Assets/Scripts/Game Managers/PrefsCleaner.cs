using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsCleaner : MonoBehaviour
{
    [Header("Button References")]
    [SerializeField] private GameObject ButtonPlayer1LeftSide;
    [SerializeField] private GameObject ButtonPlayer1RightSide;
    [SerializeField] private GameObject ButtonPlayer2LeftSide;
    [SerializeField] private GameObject ButtonPlayer2RightSide;


    void Start()
    {
        PlayerPrefs.DeleteAll();
        EnableButtons();
    }

    private void OnDestroy()
    {
        PlayerPrefs.DeleteAll();
        EnableButtons();
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        EnableButtons();
    }

    void EnableButtons()
    {
        if (ButtonPlayer1LeftSide && ButtonPlayer1RightSide && ButtonPlayer2LeftSide && ButtonPlayer2RightSide)
        {
            ButtonPlayer1LeftSide.SetActive(true);
            ButtonPlayer1RightSide.SetActive(true);
            ButtonPlayer2LeftSide.SetActive(true);
            ButtonPlayer2RightSide.SetActive(true);
        }
        else
        {
            Debug.LogError("One of the buttons from \"PrefsCleaner\" script is null!");
        }
    }
}
