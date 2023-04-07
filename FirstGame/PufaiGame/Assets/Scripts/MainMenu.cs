using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
