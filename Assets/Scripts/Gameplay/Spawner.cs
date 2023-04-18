using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefabUp;
    public float minDelay = 1f;
    public float maxDelay = 10f;
    public float moveSpeed = 5f;
    public float destroyX = -10f;


    private List<GameObject> obstacleList = new List<GameObject>();

    void Start()
    {
        Spawn();
        StartCoroutine(SpeedUp());
    }



    void Update()
    {
        for (int i = obstacleList.Count - 1; i >= 0; i--)
        {
            GameObject obstacle = obstacleList[i];
            obstacle.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if (obstacle.transform.position.x < destroyX)
            {
                Destroy(obstacle);
                obstacleList.RemoveAt(i);
            }
        }

    }

    public void Invoke()
    {
        if (Random.Range(1, 3) == 1)
        {
            Invoke("Spawn", Random.Range(minDelay, maxDelay));
        }
        else
        {
            Invoke("SpawnUp", Random.Range(minDelay, maxDelay));
        }

    }

    public void Spawn()
    {
        GameObject obstacle = Instantiate(obstaclePrefab, new Vector2(23f, -3.2f), Quaternion.identity);
        obstacleList.Add(obstacle);
    }
    public void SpawnUp()
    {
        GameObject obstacle = Instantiate(obstaclePrefabUp, new Vector2(23f, -1.5f), Quaternion.identity);
        obstacleList.Add(obstacle);
    }

    private IEnumerator SpeedUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            moveSpeed += 0.05f;
        }

    }

    public void DestroyAll()
    {
    }
}
