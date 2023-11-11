using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplainPullstack : MonoBehaviour
{
    [SerializeField] private string ExplanationSceneName = "";

    public void Explain()
    {
        SceneManager.LoadScene(ExplanationSceneName);
    }
}
