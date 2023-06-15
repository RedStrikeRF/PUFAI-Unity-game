using UnityEngine;
using UnityEngine.UI;

public class ChestLevel : MonoBehaviour
{
    public InputField input;
    public Text errorText;
    public Text loseText;
    public Button final;
    public Button restartButton;
    public AudioSource sound;
    public AudioClip chestOpen;

    public string SetVector()
    {
        try
        {
            var text = input.text;
            if (text != "cos3pi/2+isin3pi/2")
            {
                Lose();
            }
            else
            {
                Win();
            }
            return text;
        }
        catch
        {
            errorText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            return null;
        }
    }

    private void Lose()
    {
        restartButton.gameObject.SetActive(true);
        loseText.gameObject.SetActive(true);
    }

    private void Win()
    {
        sound.PlayOneShot(chestOpen);
        final.gameObject.SetActive(true);
    }

    //здесь start
    public void ButtonPressed()
    {
        Debug.Log(SetVector());
        SetVector();
    }
}
