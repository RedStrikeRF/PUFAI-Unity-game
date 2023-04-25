using TMPro;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 3;
    private int press = 0;
    public TMP_InputField user;
    public bool IsPressed;
    public Vector2 SetVector()
    {
        string XX = user.text;
        var coordinate = XX.Split(',');
        direction.x = float.Parse(coordinate[0]);
        direction.y = float.Parse(coordinate[1]);
        return direction;
    }

    public void SetVectors()
    {
        Debug.Log(SetVector());
    }

    public void ButtonPressed()
    {
        IsPressed = true;
    }

    public void GetTarget()
    {
        SetVector();
        transform.Translate(direction * speed);
    }

    void Update()
    {
        if (IsPressed)
            GetTarget();
    }
}
