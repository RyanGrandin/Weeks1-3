using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShovelMovement : MonoBehaviour
{
    public bool carrySnow = false;
    public PlayerMovement playerMovement;
    Vector2 shovelScoopPosition = new Vector2();
    public SpriteRenderer acornPileAreaSR;
    public SpriteRenderer snowDropAreaSR;
    public SpriteRenderer shovelSR;
    public Sprite scoopDefault;
    public Sprite scoopTipped;
    public GameObject shovelledSnow;
    int shovelledCount = 0;
    public TextMeshProUGUI shovelledCountDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        acornPileAreaSR.color = new Color(acornPileAreaSR.color.r, acornPileAreaSR.color.g, acornPileAreaSR.color.b, 0);
        snowDropAreaSR.color = new Color(snowDropAreaSR.color.r, snowDropAreaSR.color.g, snowDropAreaSR.color.b, 0);
        shovelledSnow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.play)
        {
            shovelScoopPosition.Set(transform.position.x - 2, transform.position.y + 0.5f);

            if (acornPileAreaSR.bounds.Contains(shovelScoopPosition))
            {
                carrySnow = true;
            }

            if (snowDropAreaSR.bounds.Contains(shovelScoopPosition))
            {
                shovelSR.sprite = scoopTipped;
                if (carrySnow)
                {
                    shovelledCount += 1;
                    carrySnow = false;
                }
            }
            else
            {
                shovelSR.sprite = scoopDefault;
            }

            if (carrySnow)
            {
                shovelledSnow.SetActive(true);
            }
            else
            {
                shovelledSnow.SetActive(false);
            }

            shovelledCountDisplay.text = "snow shovelled = " + shovelledCount + "Kg";

            // get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            // convert object position to a vector2
            Vector2 newPos = transform.position;
            // set object y position to equal mouse y position
            newPos.y = Mathf.Clamp(mousePos.y, -3, -1);
            // apply position changes back to the object's real position
            transform.position = newPos;
        }
    }
}
