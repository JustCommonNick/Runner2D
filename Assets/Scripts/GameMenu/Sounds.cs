using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip[] songs;
    public AudioSource asource;

    public void ButtonClickSound()
    {
        asource.clip = songs[0];
        asource.Play();
    }

    public void TouchGround()
    {
        asource.clip = songs[1];
        asource.Play();
    }

    public void HitEnemy()
    {
        asource.clip = songs[2];
        asource.Play();
    }
    public void Move()
    {
        asource.clip = songs[3];
        asource.Play();
    }
}