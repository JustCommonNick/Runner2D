using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using YG;

[System.Serializable]
public class Score : MonoBehaviour
{
    private float ScoreUp;
    public float score;
    public GameObject score_menu;
    public GameObject scorebeforead;
    // Start is called before the first frame update
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void Start()
    {

        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
        StartCoroutine(ScoreUpCur());
    }

    void GetLoad()
    {

        if (YandexGame.savesData.showing_reward)
        {
            score = YandexGame.savesData.reward_score;
            YandexGame.savesData.showing_reward = false;
            YandexGame.SaveProgress();
        }
        else
        {
            score = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        score += (1 + ScoreUp) * Time.deltaTime;
        this.GetComponent<TextMeshProUGUI>().text = $"{(int)score}";
        score_menu.GetComponent<TextMeshProUGUI>().text = $"{(int)score}";
    }

    private IEnumerator ScoreUpCur()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            ScoreUp += 0.03f;
        }

    }
}
