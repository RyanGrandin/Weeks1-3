using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public bool mouseIsOverMe = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position (in pixels) and convert to world space (in metres)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // get distance between shape and mouse positions
        float distance = Vector2.Distance(transform.position, mousePos);

        // if distance  is small, set mouseIsOverMe to true
        if (distance < 1)
        {
            mouseIsOverMe = true;
        }

        // otherwise, set mouseIsOverMe to false
        else
        {
            mouseIsOverMe = false;
        }
    }
}
