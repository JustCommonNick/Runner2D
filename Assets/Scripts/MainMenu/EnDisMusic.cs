using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class EnDisMusic : MonoBehaviour
{
    public GameObject off_ico;
    bool SoundOn;

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;


    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    public void MusicInGame()
    {

        if (SoundOn)
        {
            SoundOn = false;
            YandexGame.savesData.SoundOn = SoundOn;
            AudioListener.volume = 0;
            off_ico.SetActive(true);
        }
        else
        {
            SoundOn = true;
            YandexGame.savesData.SoundOn = SoundOn;
            AudioListener.volume = 1;
            off_ico.SetActive(false);
        }
        YandexGame.SaveProgress();
    }

    public void GetLoad()
    {

        SoundOn = YandexGame.savesData.SoundOn;
        if (!SoundOn)
        {
            off_ico.SetActive(true);
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
            off_ico.SetActive(false);
        }
    }

}
