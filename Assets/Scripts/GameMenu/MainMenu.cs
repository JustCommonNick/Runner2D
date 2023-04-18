using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSceneOnClick()
    {
        Time.timeScale = 1;
        Invoke("BeforeStartSceneOnClick", 0.2f);
        Debug.Log("сработала кнопка открытие главного меню");
    }

    void BeforeStartSceneOnClick()
    {
        Debug.Log("Сработало открытие главного меню");
        SceneManager.LoadScene("Main");

    }
}
