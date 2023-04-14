using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public bool time = true;
    public GameObject[] uiObjects;
    public GameObject score_main;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (time == true)
            {
                Time.timeScale = 0;
                time = false;
                foreach (GameObject uiObject in uiObjects)
                {
                    uiObject.SetActive(true);
                }
                score_main.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                time = true;
                foreach (GameObject uiObject in uiObjects)
                {
                    uiObject.SetActive(false);
                }
                score_main.SetActive(true);
            }
        }
    }
}
