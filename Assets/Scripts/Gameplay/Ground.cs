using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    GameObject GroundSpawn;
    GameObject Spawner;


    // Start is called before the first frame update
    void Start()
    {
        GroundSpawn = GameObject.Find("SpawnGround");
        Spawner = GameObject.Find("SpawnDown");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Translate(Vector3.left * Spawner.GetComponent<Spawner>().moveSpeed * Time.deltaTime);

        if (this.gameObject.transform.position.x < GroundSpawn.GetComponent<GroundSpawn>().destroyX)
        {
            GroundSpawn.GetComponent<GroundSpawn>().Spawn();
            Destroy(this.gameObject);
        }
    }
}
