using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject groundprefab;
    public float Delay = 10f;
    public float moveSpeed = 5f;
    public float destroyX = -10f;


    private List<GameObject> obstacleList = new List<GameObject>();

    public void Start()
    {
        Spawn();
    }

    public void Invoke()
    {
            Invoke("Spawn", Delay);
    }

    public void Spawn()
    {
        Instantiate(groundprefab, new Vector3(35f, -2.318135f, -1f), Quaternion.identity);
    }


}
