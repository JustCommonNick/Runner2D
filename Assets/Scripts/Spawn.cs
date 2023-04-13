using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private Spawner script;

    void Start()
    {
        GameObject spawn = GameObject.Find("SpawnDown");
        script = spawn.GetComponent<Spawner>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Trigger")
        {
            script.Invoke();

        }

    }
}
