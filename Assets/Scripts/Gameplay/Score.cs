using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private int score;
    public GameObject score_menu;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        this.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
        score_menu.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
}
