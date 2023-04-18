using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBeforeLoss : MonoBehaviour
{
    public GameObject lose;
    

    public void Restart()
    {
        Time.timeScale = 1;
        Invoke("BeforeRestart", 0.2f);
        Debug.Log("сработала кнопка рестарт");
    }

    void BeforeRestart()
    {
        Debug.Log("сработал рестарт");
        lose.GetComponent<Loss>().false_loss();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
