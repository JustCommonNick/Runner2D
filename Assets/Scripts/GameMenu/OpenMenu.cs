using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public bool time = true;
    public GameObject[] uiObjects;
    public GameObject score_main;
    public GameObject Player;
    private bool _lose;

    void Update()
    {
        _lose = Player.GetComponent<Loss>().loss;
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
                Player.GetComponent<CapsuleCollider2D>().enabled = false;
            }
            else if (_lose == false)
            {
                Time.timeScale = 1;
                time = true;
                foreach (GameObject uiObject in uiObjects)
                {
                    uiObject.SetActive(false);
                }
                score_main.SetActive(true);
                Player.GetComponent<CapsuleCollider2D>().enabled = true;
            }
        }
    }
}
