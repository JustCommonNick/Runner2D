using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour
{
    public GameObject[] uiObjects;
    public GameObject score_main;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spike")
        {
            Time.timeScale = 0;
            foreach (GameObject uiObject in uiObjects)
            {
                uiObject.SetActive(true);
            }
            score_main.SetActive(false);
        }

    }
}
