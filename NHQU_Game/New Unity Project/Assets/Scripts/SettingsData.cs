using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SettingsData : MonoBehaviour
{
    public float volume;

    public SettingsData (SettingsMenu settingsMenu)
    {
        volume = settingsMenu.volume;
    }
}
