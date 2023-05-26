using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AdaptOnMobile : MonoBehaviour
{
    private bool OpenMobileButtons = true;
    public GameObject ButtonMenu;
    public GameObject ButtonUp;
    public GameObject ButtonDown;

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    // Update is called once per frame
    public void GetLoad()
    {
        if (YandexGame.EnvironmentData.isMobile)
        {
            ButtonMenu.SetActive(true);
            ButtonUp.SetActive(true);
            ButtonDown.SetActive(true);
        }
    }

    public void OpenCloseMobileButtons()
    {
        if (OpenMobileButtons)
        {
            ButtonUp.SetActive(false);
            ButtonDown.SetActive(false);
            OpenMobileButtons = false;
        }
        else
        {
            ButtonUp.SetActive(true);
            ButtonDown.SetActive(true);
            OpenMobileButtons = true;
        }
    }

    public void ActiveFalseMobileUI()
    {
        ButtonMenu.SetActive(false);
        ButtonUp.SetActive(false);
        ButtonDown.SetActive(false);
    }
}
