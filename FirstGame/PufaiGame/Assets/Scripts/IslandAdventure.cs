using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class IslandAdventure : MonoBehaviour
{
    public InputField setCoordinate;
    public Text errorText;
    public Text loseText;
    public Text winText;
    public Button restartButton;
    public Button nextLevel;

    private readonly int targetPosition = 250;
    private readonly int maxY = 950;
    private readonly int minX = 550;
    private readonly int maxX = 1650;
    private readonly float speed = 3;
    private Vector2 parrotDirection;
    public bool isDone;

    void Update()
    {
        if (transform.position.y >= targetPosition && transform.position.y <= maxY
            && transform.position.x >= minX && transform.position.x <= maxX)
            transform.Translate(parrotDirection * speed);
    }

    private Vector2 SetVectors()
    {
        try
        {
            // Сделать так, чтобы сплит работал
            var input = setCoordinate.ToString().Split('(').ToArray();
            parrotDirection.x = float.Parse(input[0]) * (float)Math.Cos(3 * Math.PI / 2);
            parrotDirection.y = float.Parse(input[0]) * (float)Math.Sin(3 * Math.PI / 2);
            if (parrotDirection.x != 4 * Math.Cos(3 * Math.PI / 2) || parrotDirection.y != 4 * Math.Sin(3 * Math.PI / 2))
            {
                Lose();
            }
            else
            {
                Win();
            }
            return parrotDirection;
        }
        catch
        {
            errorText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            return new Vector2(0, 0);
        }
    }

    private void Lose()
    {
        restartButton.gameObject.SetActive(true);
        loseText.gameObject.SetActive(true);
    }

    public bool Win()
    {
        isDone = true;
        nextLevel.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
        return isDone;
    }

    //здесь start
    public void ButtonPressed()
    {
        Debug.Log(SetVectors());
        SetVectors();
    }
}
