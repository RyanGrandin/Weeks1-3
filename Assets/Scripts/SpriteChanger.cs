using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels;
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            // PickARandomColour();
            PickARandomSprite();
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
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        // pick a random number
        randomNumber = Random.Range(0, barrels.Length);
        // assign that sprite to a sprite renderer
        spriteRenderer.sprite = barrels[randomNumber];
    }
}
