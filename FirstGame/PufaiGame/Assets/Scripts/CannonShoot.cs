using TMPro;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 3;
    private int press = 0;
    public TMP_InputField user;

    public void SetVector()
    {
        string XX = user.text;
        var coordinate = XX.Split(',');
        direction.x = float.Parse(coordinate[0]);
        direction.y = float.Parse(coordinate[1]);
        Debug.Log(direction.x);
    }

    public void ButtonPress()
    {
        press += 1;
        Debug.Log(press);
    }

    void Update()
    {
        Debug.Log("gg");
        transform.Translate(direction * speed);
    }
}
