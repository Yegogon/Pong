using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] private string NameOfLevel = "";

    public void ResetGame()
    {
        SceneManager.LoadScene(NameOfLevel);
    }
}
