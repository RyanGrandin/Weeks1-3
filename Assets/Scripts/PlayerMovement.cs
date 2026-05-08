using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public bool play = false;
    public GameObject startCanvasGO;
    public GameObject playCanvasGO;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        startCanvasGO.SetActive(true);
        playCanvasGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (play) 
        {
            // get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            // convert object position to a vector2
            Vector2 newPos = transform.position;
            // set object x position to equal mouse x position
            newPos.x = mousePos.x;
            // apply position changes back to the object's real position
            transform.position = newPos;
        }
    }

    public void StartPlay()
    {
        play = true;
        startCanvasGO.SetActive(false);
        playCanvasGO.SetActive(true);
    }
}
