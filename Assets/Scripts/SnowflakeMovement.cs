using UnityEngine;

public class SnowflakeMovement : MonoBehaviour
{
    private Vector2 startScreenPos;
    private Vector2 endScreenPos;
    public Vector2 startWorldPos;
    public Vector2 endWorldPos;
    public float t;
    public float speed = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set random snowflake starting and ending x positons
        startScreenPos.Set(Random.Range(0, Screen.width), Screen.height);
        endScreenPos.Set(Random.Range(0, Screen.width), 0);
        startWorldPos = Camera.main.ScreenToWorldPoint(startScreenPos);
        endWorldPos = Camera.main.ScreenToWorldPoint(endScreenPos);

        // give snowflake a random speed
        speed = Random.Range(0.2f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(startWorldPos, endWorldPos, t);
        t += speed * Time.deltaTime;
        // once the snowflake has reached the bottom of the screen, set it back to its starting positon and give it a new start 
        // and end position
        if (t > 1)
        {
            t = 0;
            startScreenPos.Set(Random.Range(0, Screen.width), Screen.height);
            endScreenPos.Set(Random.Range(0, Screen.width), 0);
            startWorldPos = Camera.main.ScreenToWorldPoint(startScreenPos);
            endWorldPos = Camera.main.ScreenToWorldPoint(endScreenPos);
            // give snowflake a random speed
            speed = Random.Range(0.2f, 0.5f);
        }
    }
}
