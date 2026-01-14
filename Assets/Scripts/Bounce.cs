using UnityEngine;

public class Bounce : MonoBehaviour
{
    Vector2 newPosition;
    Vector2 screenPosition;
    public float xspeed = 1;
    public float yspeed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move
        newPosition = transform.position;
        newPosition.x += xspeed * Time.deltaTime;
        newPosition.y += yspeed * Time.deltaTime;

        //bounce
        /*screenPosition = Camera.main.ScreenToWorldPoint(transform.position);
        if (screenPosition.x < 0 || screenPosition.x < Screen.width)
        {
            xspeed *= -1;
        }
        if (screenPosition.y < 0 || screenPosition.y < Screen.height)
        {
            yspeed *= -1;
        }*/

        transform.position = newPosition;
    }
}
