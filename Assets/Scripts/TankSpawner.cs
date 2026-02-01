using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int tankCount;
    public GameObject spawnedTank;

    public FirstScript tankScript;
    public SpriteRenderer tankSR;

    public List<GameObject> tanks;
    public Transform barrel;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // Instantiate(tankPrefab, transform.position, transform.rotation);
            Vector2 spawnPos = Random.insideUnitCircle * 3;
            spawnedTank = Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            tankScript = spawnedTank.GetComponent<FirstScript>();
            tankSR = spawnedTank.GetComponent<SpriteRenderer>();

            tankCount++;

            tankScript.speed = tankCount;
            //tankScript.body.color = Random.ColorHSV();

            tanks.Add(spawnedTank);

            // loop through tanks list
            // get firstScript component
            // set speed to tankCount
            for (int i = 0; i < tanks.Count; i++)
            {
                FirstScript ts = tanks[i].GetComponent<FirstScript>();
                ts.speed = tankCount;
            }
        }
        // loop through tanks
        // get transform
        // compare position to barrel
        for (int i = 0; i < tanks.Count; i++)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if (distance < 0.5f)
            {
                Debug.Log("Explode tank " + i);
            }
        }
    }
}
