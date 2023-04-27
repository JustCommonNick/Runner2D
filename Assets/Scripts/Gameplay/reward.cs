using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class reward : MonoBehaviour
{
    [SerializeField] int AdID;
    public GameObject scoreingame;

    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    void Rewarded(int id)
    {
        if (id == AdID)
        {
            YandexGame.savesData.reward_score = (int)scoreingame.GetComponent<Score>().score;
            YandexGame.savesData.showing_reward = true;
            YandexGame.SaveProgress();

        }
    }

}
