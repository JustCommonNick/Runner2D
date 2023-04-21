using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnDisMusic : MonoBehaviour
{
    public GameObject off_ico;
    int enable;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("Music"));
        enable = PlayerPrefs.GetInt("Music");
        if (PlayerPrefs.GetInt("Music") == 0)
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

    void Update()
    {

    }

    public void MusicInGame()
    {

        if (enable == 1)
        {
            enable = 0;
            PlayerPrefs.SetInt("Music", 0);
            AudioListener.volume = 0;
            off_ico.SetActive(true);
            Debug.Log("Выключена музыка");
        }
        else
        {
            enable = 1;
            PlayerPrefs.SetInt("Music", 1);
            AudioListener.volume = 1;
            off_ico.SetActive(false);
            Debug.Log("Включена музыка");
        }
    }
}
