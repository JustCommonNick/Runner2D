using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private float score;
    public GameObject score_menu;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        this.GetComponent<TextMeshProUGUI>().text = $"Score: {(int)score}";
        score_menu.GetComponent<TextMeshProUGUI>().text = $"Score: {(int)score}";
    }
}
