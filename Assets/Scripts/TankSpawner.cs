using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int tankCount;
    public GameObject spawnedTank;

    public FirstScript tankScript;
    public SpriteRenderer tankSR;
    
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
            tankScript.body.color = Random.ColorHSV();
        }
    }
}
