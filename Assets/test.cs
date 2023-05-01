using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = YandexGame.EnvironmentData.language;
    }
}
