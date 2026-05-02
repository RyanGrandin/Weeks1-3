using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 screenRightSide = new Vector2(Screen.width, Screen.height);
    Vector2 worldRightSide = new Vector2();
    public float distance = 0;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        worldRightSide = Camera.main.ScreenToWorldPoint(screenRightSide);
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // convert object position to a vector2
        Vector2 newPos = transform.position;
        // set object x position to equal mouse x position
        newPos.x = mousePos.x;
        // apply position changes back to the object's real position
        transform.position = newPos;

        worldRightSide.Set(worldRightSide.x, transform.position.y);
        distance = Vector2.Distance(worldRightSide, transform.position);

        Vector2 newScale = transform.localScale;
        newScale.x = distance / 5;
        newScale.y = distance / 5;
        transform.localScale = newScale;

        Vector2 newNewPos = transform.position;
        newNewPos.y = distance / 5 - 6;
        transform.position = newNewPos;
    }
}
