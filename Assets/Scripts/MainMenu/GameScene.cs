using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{

    public void StartSceneOnClick()
    {
        Invoke("StartScene", 0.3f);
    }

    void StartScene()
    {
        SceneManager.LoadScene("Game");
    }
}
