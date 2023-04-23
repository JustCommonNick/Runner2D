using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioClip song;
    public AudioSource asource;

    public void ButtonClickSound(bool penis)
    {
        asource.clip = song;
        asource.Play();
    }
}
