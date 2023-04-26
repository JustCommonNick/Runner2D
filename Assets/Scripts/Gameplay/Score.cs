using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using YG;


[System.Serializable]
public class Score : MonoBehaviour
{
    public float score;
    public GameObject score_menu;
    // Start is called before the first frame update
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
        score = YandexGame.savesData.reward_score;
    }

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        this.GetComponent<TextMeshProUGUI>().text = $"{(int)score}";
        score_menu.GetComponent<TextMeshProUGUI>().text = $"{(int)score}";
    }
}
