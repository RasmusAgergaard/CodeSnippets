using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Transform enemyPrefab;
    public float spawnTime;

    private float _sinceLastSpawn;

    // Start is called before the first frame update
    void Start()
    {
        _sinceLastSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _sinceLastSpawn += Time.deltaTime;

        if (_sinceLastSpawn >= spawnTime)
        {
            var spawnPosition = transform.position;
            spawnPosition.x = Random.Range(-95, 95);

            var spawnedEnemy = Instantiate(enemyPrefab);
            spawnedEnemy.position = spawnPosition;


            Debug.Log(spawnTime);
            _sinceLastSpawn = 0;
        }
    }
}
