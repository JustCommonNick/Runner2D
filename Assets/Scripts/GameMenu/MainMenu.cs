using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSceneOnClick()
    {
        Invoke("InvokeStartSceneOnClick", 0.2f);
    }

    void InvokeStartSceneOnClick()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
