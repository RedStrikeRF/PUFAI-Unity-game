using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipAdventure : MonoBehaviour
{
    public bool IsPressed = false;
    public Vector2 direction;
    private int targetPosition = 250;
    private int maxY = 950;
    private int minX = 550;
    private int maxX = 1650;
    private float speed = 3;
    private static int waitSeconds = 100;
    public WaitForSeconds wait;
    public TMP_InputField user;
    public TextMeshProUGUI loseText;
    public Button startButton;

    void Update()
    {
        if (transform.position.y >= targetPosition && transform.position.y <= maxY
            && transform.position.x >= minX && transform.position.x <= maxX)
            transform.Translate(direction * speed);
    }

    public void Lose()
    {
        loseText.gameObject.SetActive(true);
        SceneManager.LoadScene("FirstLevel");
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

    private WaitForSeconds Wait()
    {
        wait = new WaitForSeconds(waitSeconds);
        return wait;
    }
}
