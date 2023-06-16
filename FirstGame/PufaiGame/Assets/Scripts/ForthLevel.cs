using UnityEngine;
using UnityEngine.UI;

public class ForthLevel : MonoBehaviour
{
    public InputField Set1, Set2, Set3, Set4;
    public Text errorText;
    public Text loseText;
    public Text winText;
    public Button restartButton;
    public Button nextLevel;
    public Image target1, target2, target3, target4;
    public Image shadow1, shadow2, shadow3, shadow4;
    public AudioSource sound;
    public AudioClip indians;

    private string z1, z2, z3, z4;

    public string SetNumbers()
    {
        try
        {
            z1 = Set1.text;
            z2 = Set2.text;
            z3 = Set3.text;
            z4 = Set4.text;
            // Возможно это можно сократить
            switch (z1)
            {
                case "1" when z2 == "-1" && z3 == "i" && z4 == "-i":
                case "1" when z2 == "-1" && z3 == "-i" && z4 == "i":
                case "1" when z2 == "i" && z3 == "-1" && z4 == "-i":
                case "1" when z2 == "i" && z3 == "-i" && z4 == "-1":
                case "1" when z2 == "-i" && z3 == "i" && z4 == "-1":
                case "1" when z2 == "-i" && z3 == "-1" && z4 == "i":
                case "-1" when z2 == "1" && z3 == "i" && z4 == "-i":
                case "-1" when z2 == "1" && z3 == "-i" && z4 == "i":
                case "-1" when z2 == "i" && z3 == "1" && z4 == "-i":
                case "-1" when z2 == "i" && z3 == "-i" && z4 == "1":
                case "-1" when z2 == "-i" && z3 == "i" && z4 == "1":
                case "-1" when z2 == "-i" && z3 == "1" && z4 == "i":
                case "i" when z2 == "-1" && z3 == "1" && z4 == "-i":
                case "i" when z2 == "-1" && z3 == "-i" && z4 == "1":
                case "i" when z2 == "1" && z3 == "-1" && z4 == "-i":
                case "i" when z2 == "1" && z3 == "-i" && z4 == "-1":
                case "i" when z2 == "-i" && z3 == "1" && z4 == "-1":
                case "i" when z2 == "-i" && z3 == "-1" && z4 == "1":
                case "-i" when z2 == "-1" && z3 == "1" && z4 == "i":
                case "-i" when z2 == "-1" && z3 == "i" && z4 == "1":
                case "-i" when z2 == "1" && z3 == "-1" && z4 == "i":
                case "-i" when z2 == "1" && z3 == "i" && z4 == "-1":
                case "-i" when z2 == "i" && z3 == "1" && z4 == "-1":
                case "-i" when z2 == "i" && z3 == "-1" && z4 == "1":
                    Win();
                    break;
                default:
                    Lose();
                    break;
            }
            return z1;
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
        shadow1.gameObject.SetActive(false);
        shadow2.gameObject.SetActive(false);
        shadow3.gameObject.SetActive(false);
        shadow4.gameObject.SetActive(false);

        target1.gameObject.SetActive(true);
        target2.gameObject.SetActive(true);
        target3.gameObject.SetActive(true);
        target4.gameObject.SetActive(true);
        sound.PlayOneShot(indians);

        nextLevel.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
    }

    //здесь start
    public void ButtonPressed()
    {
        Debug.Log(SetNumbers());
        SetNumbers();
    }
}
