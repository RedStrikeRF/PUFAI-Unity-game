using UnityEngine;
using UnityEngine.UI;

public class ShipAdventure : MonoBehaviour
{
    public InputField SetX;
    public InputField SetY;
    public Text loseText;
    public Text winText;
    public Button restartButton;
    public Button nextLevel;

    private readonly int targetPosition = 250;
    private readonly int maxY = 950;
    private readonly int minX = 550;
    private readonly int maxX = 1650;
    private readonly float speed = 3;
    private Vector2 shipDirection;

    public bool IsDone { get; set; }

    void Update()
    {
        if (transform.position.y >= targetPosition && transform.position.y <= maxY
            && transform.position.x >= minX && transform.position.x <= maxX)
            transform.Translate(shipDirection * speed);
    }

    private Vector2 SetVectors()
    {
        shipDirection.x = float.Parse(SetX.text);
        shipDirection.y = float.Parse(SetY.text);
        if (shipDirection.x != 0 || shipDirection.y != -1)
        {
            Lose();
        }
        else
        {
            Win();
        }
        return shipDirection;
    }

    private void Lose()
    {
        restartButton.gameObject.SetActive(true);
        loseText.gameObject.SetActive(true);
    }

    public bool Win()
    {
        IsDone = true;
        nextLevel.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
        return IsDone;
    }

    //здесь start
    public void ButtonPressed()
    {
        Debug.Log(SetVectors());
        SetVectors();
    }
}
