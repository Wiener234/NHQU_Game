using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volume;

    private void Awake()
    {
        try
        {
            SettingsData data = SaveSystem.LoadSettings();
            volume = data.volume;
        }
        catch
        {

        }
    }

    public void Quit()
    {
        SaveSystem.SaveSettings(this);
    }

    public void OnVolume(float vol)
    {
        volume = vol;
        audioMixer.SetFloat("volume", volume);
        
    }
}
