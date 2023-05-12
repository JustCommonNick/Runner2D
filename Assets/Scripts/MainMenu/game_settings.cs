using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_settings : MonoBehaviour
{
    public GameObject music;
    public GameObject back_button;
    public GameObject start;
    public GameObject settings;
    public GameObject b_score;
    public GameObject b_score_label;


    public void OpenSettings()
    {
        start.SetActive(false);
        settings.SetActive(false);
        b_score.SetActive(false);
        music.SetActive(true);
        back_button.SetActive(true);
        b_score_label.SetActive(false);
    }

    public void CloseSettings()
    {
        music.SetActive(false);
        back_button.SetActive(false);
        start.SetActive(true);
        settings.SetActive(true);
        b_score.SetActive(true);
        b_score_label.SetActive(true);
    }
}
