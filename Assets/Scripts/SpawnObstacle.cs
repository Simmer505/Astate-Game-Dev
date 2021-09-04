using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject Obstacle;
    public float spawnTime;

    private bool spawned = false;
    private float offset;
    private Vector3 spawnPos;

    // Update is called once per frame
    void Update()
    {
        if (!spawned)
        {
            offset = Random.Range(-3.5f, 3.5f);
            spawnPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + offset);
            Instantiate(Obstacle, spawnPos, Quaternion.identity);
            spawned = true;
            StartCoroutine(SpawnTimer());
            
        }
    }

    IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        spawned = false;
    }
}
