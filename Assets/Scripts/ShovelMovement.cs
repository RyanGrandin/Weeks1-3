using UnityEngine;
using UnityEngine.InputSystem;

public class ShovelMovement : MonoBehaviour
{
    //public SpriteRenderer shovelSR;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // convert object position to a vector2
        Vector2 newPos = transform.position;
        // set object y position to equal mouse y position
        newPos.y = mousePos.y;
        // apply position changes back to the object's real position
        transform.position = newPos;

        //if (transform.position.magnitude.Equals(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 4))))
        //{
        //    shovelSR.color = Color.green;
        //}
    }
}
