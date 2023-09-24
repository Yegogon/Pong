using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioSettings : MonoBehaviour
{
    [Header("Music Parameters' References")]
    [SerializeField] private Slider AdjustMusic;
    [SerializeField] private TextMeshProUGUI MusicValue;

    [Header("SFX Parameters' References")]
    [SerializeField] private Slider AdjustSFX;
    [SerializeField] private TextMeshProUGUI SFXValue;

    private SoundWire wireInput;

    void Awake()
    {
        wireInput = new SoundWire();

        AdjustMusic.onValueChanged.AddListener(
            (newValue) => 
            {
                MusicValue.text = newValue.ToString();
                wireInput.MusicWire = newValue;
            }
            );

        AdjustSFX.onValueChanged.AddListener(
            (newValue) =>
            {
                SFXValue.text = newValue.ToString();
                wireInput.SFXWire = newValue;
            }
            );
    }
}
