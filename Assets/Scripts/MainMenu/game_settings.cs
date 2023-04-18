using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_settings : MonoBehaviour
{
    public GameObject music;
    public GameObject back_button;
    public GameObject settings_panel;

    public void OpenSettings()
    {
        music.SetActive(true);
        back_button.SetActive(true);
        settings_panel.SetActive(true);
    }

    public void CloseSettings()
    {
        music.SetActive(false);
        back_button.SetActive(false);
        settings_panel.SetActive(false);
    }
}
