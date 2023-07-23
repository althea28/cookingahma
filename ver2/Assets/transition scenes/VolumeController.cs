using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource != null)
        {
            // Set the initial volume value based on the slider value
            SetVolume(volumeSlider.value);

            // Subscribe to the slider's OnValueChanged event
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
        else
        {
            Debug.LogWarning("AudioSource component is missing. Volume control will not work.");
        }
    }

    private void SetVolume(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = volume;
        }
        else
        {
            Debug.LogWarning("AudioSource component is missing. Volume control will not work.");
            return;
        }
    }
}