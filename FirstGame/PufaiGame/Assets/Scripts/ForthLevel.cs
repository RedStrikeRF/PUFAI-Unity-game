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

    private string z1, z2, z3, z4;

    void Update()
    {

    }



    public string SetVector()
    {
        try
        {
            z1 = Set1.text;
            z2 = Set2.text;
            z3 = Set3.text;
            z4 = Set4.text;
            if ((z1 != "1" || z1 != "-1" || z1 != "i" || z1 != "-i")
                && (z2 != "1" || z2 != "-1" || z2 != "i" || z2 != "-i")
                && (z3 != "1" || z3 != "-1" || z3 != "i" || z3 != "-i")
                && (z4 != "1" || z4 != "-1" || z4 != "i" || z4 != "-i"))
            {
                Lose();
            }
            else
            {
                Win();
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
