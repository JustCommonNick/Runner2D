using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class reward : MonoBehaviour
{

    private void OnEnable() => YandexGame.GetDataEvent += Reward;
    private void OnDisable() => YandexGame.GetDataEvent -= Reward;

    void Reward()
    {
        if (YandexGame.SDKEnabled == true)
        {
            
        }
    }
}
