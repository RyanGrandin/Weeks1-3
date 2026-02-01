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

    public GameObject duckPrefab;
    
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

            Instantiate(duckPrefab, Random.insideUnitCircle * 3, Quaternion.identity);
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            tanks.Remove(spawnedTank);
            Destroy(spawnedTank);
        }

        // loop through tanks
        // get transform
        // compare position to barrel
        for (int i = tanks.Count - 1; i >= 0; i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if (distance < 0.5f)
            {
                Debug.Log("Explode tank " + i);
                //make local variable to get ref to tank
                GameObject tank = tanks[i];
                // remove tank from list
                tanks.Remove(tank);
                // destroy tank
                Destroy(tank);
            }
        }
    }
}
