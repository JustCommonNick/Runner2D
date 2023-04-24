using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;

public class StartMainMenu : MonoBehaviour
{
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;


    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    void GetLoad()
    {
        GameObject.Find("BestScore").GetComponent<TextMeshProUGUI>().text = $"Best Score: {YandexGame.savesData.BScore}";
    }
}
