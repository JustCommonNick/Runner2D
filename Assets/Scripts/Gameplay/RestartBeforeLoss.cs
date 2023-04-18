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
        Invoke("BeforeRestart", 0.1f);
    }

    void BeforeRestart()
    {
        lose.GetComponent<Loss>().false_loss();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
