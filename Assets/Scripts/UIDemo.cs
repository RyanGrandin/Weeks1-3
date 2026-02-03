using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class UIDemo : MonoBehaviour
{
    private SpriteRenderer SR;
    public Image duckImage;
    public int clickCount = 0;
    public TextMeshProUGUI score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        score.text = clickCount.ToString();
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
        duckImage.color = SR.color;
    }

    public void SetScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void countClicks()
    {
        clickCount++;
        score.text = clickCount.ToString();
    }
}
