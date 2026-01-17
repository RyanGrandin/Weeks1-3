using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    public bool leftMousePressed = false;
    public bool rightMousePressed = false;
    public bool anyKeyPressed = false;

    public float moveSpeed = 3;
    public float rotateSpeed = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // true all the time mouse is pressed
        leftMousePressed = Mouse.current.leftButton.isPressed;
        rightMousePressed = Mouse.current.rightButton.isPressed;

        //true for the first frame mouse is pressed
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Left Button Pressed");
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Debug.Log("Right Button Pressed");
        }

        anyKeyPressed = Keyboard.current.anyKey.isPressed;

        //test for left arrow key: move left
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += rotateSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        //test for right arrow key: move right
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= rotateSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        //test for up arrow key: move up
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        //test for down arrow key: move down
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }
    }
}
