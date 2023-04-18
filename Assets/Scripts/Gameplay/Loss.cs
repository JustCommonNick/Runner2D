using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour
{
    public GameObject[] uiObjects;
    public GameObject score_main;
    public bool loss = false;
    public GameObject soundmanager;

    void Update()
    {

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
            loss = true;
        }

    }

    public void false_loss()
    {
        loss = false;
    }

    void all()
    {

    }
}
