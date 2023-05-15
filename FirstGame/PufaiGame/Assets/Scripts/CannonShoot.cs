using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CannonShoot : MonoBehaviour
{
    public bool IsPressed;
    public Vector2 direction;
    public float speed = 3;
    private int press = 0;
    public TMP_InputField user;
    public TextMeshProUGUI loseText;
    public Button startButton;

    void Start()
    {
        IsPressed = false;
    }

    public Vector2 SetVector()
    {
        string XX = user.text;
        var coordinate = XX.Split(',');
        direction.x = float.Parse(coordinate[0]);
        direction.y = float.Parse(coordinate[1]);
        if (XX != "0,-1")
        {
            Thread.Sleep(1000);
            Lose();
        }
        return direction;
    }

    public void SetVectors()
    {
        Debug.Log(SetVector());
    }

    public void ButtonPressed()
    {
        if (startButton.isActiveAndEnabled)
        {
            IsPressed = true;
        }
    }

    public void GetTarget()
    {
        SetVector();
        transform.Translate(direction * speed);
    }

    public void Lose()
    {
        loseText.gameObject.SetActive(true);
    }

    void Update()
    {
        startButton.Invoke("GetTarget", 0);
    }
}
