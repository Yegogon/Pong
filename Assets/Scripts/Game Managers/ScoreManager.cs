using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text Score1;
    [SerializeField] TMP_Text Score2;

    public int Points1 
    {
        get { return _points1; } 
        set 
        {
            _points1 = value;
            Score1.text = Points1.ToString();
            PlayerPrefs.SetInt("Points1", Points1);
        } 
    }
    public int Points2
    {
        get { return _points2; }
        set
        {
            _points2 = value;
            Score2.text = Points2.ToString();
            PlayerPrefs.SetInt("Points2", Points2);
        }
    }

    int _points1 = 0;
    int _points2 = 0;
}
