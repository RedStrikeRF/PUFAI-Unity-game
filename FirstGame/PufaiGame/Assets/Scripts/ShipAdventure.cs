using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShipAdventure : MonoBehaviour
{
    public bool IsPressed = false;
    public Vector2 direction;
    public float speed = 3;
    public TMP_InputField user;
    public TextMeshProUGUI loseText;
    public Button startButton;

    void Update()
    {   
        transform.Translate(direction * speed);
    }

    public void Lose()
    {
        loseText.gameObject.SetActive(true);

    }

    public Vector2 SetVector()
    {
        string XX = user.text;
        var coordinate = XX.Split(',');
        direction.x = float.Parse(coordinate[0]);
        direction.y = float.Parse(coordinate[1]);
        if (XX != "0,-1")
        {
            Lose();
        }
        return direction;
    }

    //здесь start
    public void ButtonPressed()
    {
        IsPressed = true;
        Debug.Log(SetVector());
        SetVector();
    }
}
