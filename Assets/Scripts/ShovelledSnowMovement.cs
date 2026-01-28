using UnityEngine;
using UnityEngine.InputSystem;

public class ShovelledSnowMovement : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        startPos.x = mousePos.x - 3;
        endPos.x = mousePos.x - 3;
        transform.position = Vector2.Lerp(startPos, endPos, t);
    }
}
