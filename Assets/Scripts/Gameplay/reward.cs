using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class reward : MonoBehaviour
{
    public GameObject scoreingame;
    public GameObject panel_ads;

    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    void Rewarded(int id)
    {
        Debug.Log("Ревард отработала");
        YandexGame.savesData.reward_score = (int)scoreingame.GetComponent<Score>().score;
        YandexGame.savesData.showing_reward = true;
        YandexGame.SaveProgress();
        panel_ads.SetActive(false);
    }

    public void OpenRewardAd(int id)
    {
        YandexGame.RewVideoShow(id);
    }

}
