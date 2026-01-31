using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            // PickARandomColour();
            Debug.Log("New colour please.");
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }

        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // is the mouse position over this sprite?
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            // Y: set the colour to our color variable
            spriteRenderer.color = col;
        }
        else
        {
            // N: set the colour to white
            spriteRenderer.color = Color.white;
        }
        if (Mouse.current.leftButton.wasPressedThisFrame && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        // pick a random number
        randomNumber = Random.Range(0, barrels.Count);
        // assign that sprite to a sprite renderer
        spriteRenderer.sprite = barrels[randomNumber];
    }
}
