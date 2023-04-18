using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBeforeLoss : MonoBehaviour
{
    public GameObject lose;
    

    public void Restart()
    {
        Invoke("InvokeRestart", 0.2f);
    }

    void InvokeRestart()
    {
        lose.GetComponent<Loss>().false_loss();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
