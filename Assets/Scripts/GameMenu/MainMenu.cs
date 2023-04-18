using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSceneOnClick()
    {
        Time.timeScale = 1;
        Invoke("BeforeStartSceneOnClick", 0.1f);
    }

    void BeforeStartSceneOnClick()
    {
        SceneManager.LoadScene("Main");

    }
}
