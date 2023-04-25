using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using YG;


public class Lang : MonoBehaviour
{
    public string RU;
    public string EU;
    public string TR;

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void Awake()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    void GetLoad()
    {
        Debug.Log($"язык выставлен как: {YandexGame.EnvironmentData.language}");
        if (YandexGame.EnvironmentData.language == "ru")
        {
            Debug.Log("€зык сменен на –усский");
            this.GetComponent<TextMeshProUGUI>().text = RU;
        }
        else if (YandexGame.EnvironmentData.language == "tr")
        {
            Debug.Log("Language switch to English");
            this.GetComponent<TextMeshProUGUI>().text = TR;
        }
        else
        {
            Debug.Log("Language switch to English");
            this.GetComponent<TextMeshProUGUI>().text = EU;
        }
    }
}