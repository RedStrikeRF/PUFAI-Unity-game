using UnityEngine;
using UnityEngine.UI;

public class IslandAdventure : MonoBehaviour
{
    public InputField set;
    public Text errorText;
    public Text loseText;
    public Text winText;
    public Button restartButton;
    public Button nextLevel;
    public Image cannonBall;

    private Vector2 direction;
    private int minY = 60;
    private int maxY = 950;
    private int maxX = 1250;
    private int targetPos = 350;
    private float speed = 3;

    void Update()
    {
        if (transform.position.y >= minY && transform.position.y <= maxY
            && transform.position.x >= targetPos && transform.position.x <= maxX)
            transform.Translate(direction * speed);
    }



    public Vector2 SetVector()
    {
        try
        {
            var text = set.text;
            var input = text.Split(new char[] { '(', ')', ' ', });
            Debug.Log(input);
            direction.x = float.Parse(input[0]) * 0;
            direction.y = float.Parse(input[0]) * -1;
            if (input[1] != "cos3pi/2+isin3pi/2")
            {
                errorText.gameObject.SetActive(true);
                restartButton.gameObject.SetActive(true);
                return new Vector2(0, 0);
            }
            if (direction.x != 0 || direction.y != -4)
            {
                Lose();
            }
            else
            {
                Win();
            }
            direction.x -= 4;
            direction.y += 5;
            return direction;
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

    private void Win()
    {
        nextLevel.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
    }

    //здесь start
    public void ButtonPressed()
    {
        Debug.Log(SetVector());
        SetVector();
    }
}
