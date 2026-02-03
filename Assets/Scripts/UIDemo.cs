using UnityEngine;
using UnityEngine.InputSystem;

public class UIDemo : MonoBehaviour
{
    private SpriteRenderer SR;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            ChangeColour();
        }
    }

    public void ChangeColour()
    {
        SR.color = Random.ColorHSV();
    }

    public void SetScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
