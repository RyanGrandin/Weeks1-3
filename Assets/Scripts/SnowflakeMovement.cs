using UnityEngine;

public class SnowflakeMovement : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set random snowflake starting and ending x positons
        //startPos.Set(Random.Range(0, Screen.width), Screen.height);
        //endPos.Set(Random.Range(0, Screen.width), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(startPos, endPos, t);
    }
}
