using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Exit()
    {
        Application.Quit();

        //Debug.Log("Exit pressed!");
    }

    public void FirstLevel()
    {
        var levelName = "FirstLevel";
        Levels(levelName);
    }

    public void Levels(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //Тут начинается меню настроек

    //Настройка полного экрана
    public void FullScreenToggle()
    {
        //fullscreen;
        Screen.fullScreen = !Screen.fullScreen;
    }


    //надо сделать настройку громкости музыки через slider "volume"
    //public GameSettings am;
    public void SetAudioVolume(float sliderValue)
    {
        //masterVolume это параметр для панели громкости
        //раскомментировать когда разберемся с 
        //am.SetFloat("masterVolume", sliderValue);
    }
}
