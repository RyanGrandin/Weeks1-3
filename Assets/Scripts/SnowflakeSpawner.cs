using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawner : MonoBehaviour
{
    public GameObject snowflakePrefab;
    public GameObject spawnedSnowflake;
    public List<GameObject> snowflakes = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            spawnedSnowflake = Instantiate(snowflakePrefab);
            snowflakes.Add(spawnedSnowflake);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
