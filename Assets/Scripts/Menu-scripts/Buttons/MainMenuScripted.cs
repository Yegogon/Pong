using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripted : MonoBehaviour
{
    //declaring scenes
    [Header("Scene Names")]
    [Tooltip("Write down the asset name of this scene")]
    [SerializeField] private string TwoPlayerGame = "";
    [Tooltip("Write down the asset name of this scene")]
    [SerializeField] private string ImpossibleSingleplayer = "";
    [Tooltip("Write down the asset name of this scene")]
    [SerializeField] private string Settings = "";
    [Tooltip("Write down the asset name of this scene")]
    [SerializeField] private string Credits = "";



    //public voids for buttons
    public void LoadTwoPlayerGame()
    {
        SceneManager.LoadScene(TwoPlayerGame);
    }

    public void LoadImpossibleSingleplayer()
    {
        SceneManager.LoadScene(ImpossibleSingleplayer);
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(Settings);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(Credits);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
