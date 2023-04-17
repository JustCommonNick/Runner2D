using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSceneOnClick()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
