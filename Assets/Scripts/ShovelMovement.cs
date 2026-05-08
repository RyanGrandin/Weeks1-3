using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShovelMovement : MonoBehaviour
{
    //public SpriteRenderer shovelSR;
    public bool carrySnow = false;
    public SpriteRenderer acornPileAreaSR;
    Vector2 shovelScoopPosition = new Vector2();

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
        newPos.y = Mathf.Clamp(mousePos.y, -3, -1);
        // apply position changes back to the object's real position
        transform.position = newPos;

        //if (transform.position.magnitude.Equals(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 4))))
        //{
        //    shovelSR.color = Color.green;
        //}

        shovelScoopPosition.Set(transform.position.x-2, transform.position.y+0.5f);

        if (acornPileAreaSR.sprite.bounds.Contains(shovelScoopPosition))
        {
            carrySnow = true;
        }
        else
        {
            carrySnow = false;
        }
    }
}
