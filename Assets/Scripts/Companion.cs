using UnityEngine;

public class Companion : MonoBehaviour
{
    public Transform triangle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.localPosition;

        if (triangle.position.x < 0)
        {
            // set position to -2
            newPos.x = -2;
        }
        else
        {
            // set position to +2
            newPos.x = 2;
        }

        transform.localPosition = newPos;
    }
}
