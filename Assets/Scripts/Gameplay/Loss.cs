using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;

public class Loss : MonoBehaviour
{
    public GameObject[] uiObjects;
    public GameObject score_main;
    public bool loss = false;
    public GameObject soundmanager;
    public GameObject Score;
    public GameObject score_main_label;
    public GameObject Bscore;

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
        Bscore.GetComponent<TextMeshProUGUI>().text = $"{YandexGame.savesData.BScore}";
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            soundmanager.GetComponent<Sounds>().HitEnemy();
            Time.timeScale = 0;
            foreach (GameObject uiObject in uiObjects)
            {
                uiObject.SetActive(true);
            }
            score_main.SetActive(false);
            score_main_label.SetActive(false);
            loss = true;
            
            if (YandexGame.savesData.BScore < Score.GetComponent<Score>().score)
            {
                YandexGame.savesData.BScore = (int)Score.GetComponent<Score>().score;
                Bscore.GetComponent<TextMeshProUGUI>().text = $"{YandexGame.savesData.BScore}";
                //YandexGame.NewLeaderboardScores(string "Bscore", YandexGame.savesData.BScore);
                YandexGame.SaveProgress();
            }
            
        }

    }

    public void false_loss()
    {
        loss = false;
    }

}
