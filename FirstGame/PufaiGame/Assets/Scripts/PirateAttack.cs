using UnityEngine;
using UnityEngine.UI;

public class PirateAttack : MonoBehaviour
{
    public InputField SetX;
    public InputField SetY;
    public Text loseText;
    public Text winText;
    public Button restartButton;
    public Button nextLevel;

    private bool IsPressed;
    private Vector2 direction;
    private int minY = 60;
    private int maxY = 950;
    private int minX = 550;
    private int targetPos = 1780;
    private float speed = 3;

    void Update()
    {
        if (transform.position.y >= minY && transform.position.y <= maxY
            && transform.position.x >= minX && transform.position.x <= targetPos)
            transform.Translate(direction * speed);
    }



    public Vector2 SetVector()
    {
        direction.x = float.Parse(SetX.text);
        direction.y = float.Parse(SetY.text);
        if (direction.x != -3 || direction.y != 3)
        {
            Lose();
        }
        else
        {
            Win();
        }
        direction.x += 6;
        direction.y -= 3;
        return direction;
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

    //����� start
    public void ButtonPressed()
    {
        IsPressed = true;
        Debug.Log(SetVector());
        SetVector();
    }
}