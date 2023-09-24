using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsCleaner2 : MonoBehaviour
{
    [Header("Button References")]
    [SerializeField] private GameObject ButtonPlayer1LeftSide;
    [SerializeField] private GameObject ButtonPlayer1RightSide;


    void Start()
    {
        PlayerPrefs.DeleteAll();
        EnableButtons();
    }

    void EnableButtons()
    {
        ButtonPlayer1LeftSide.SetActive(true);
        ButtonPlayer1RightSide.SetActive(true);
    }
}
