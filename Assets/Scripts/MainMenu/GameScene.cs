using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    public AudioClip song;
    public AudioSource asource;

    public void StartSceneOnClick()
    {
        SceneManager.LoadScene("Game");
        asource.clip = song;
        asource.Play();
    }
}
