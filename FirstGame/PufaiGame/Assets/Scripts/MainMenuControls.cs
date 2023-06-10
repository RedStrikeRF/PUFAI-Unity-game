using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    private ShipAdventure shipAdventure;
    public GameObject button;

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
    }

    public void WelcomeText()
    {
        var levelName = "WelcomeText";
        Levels(levelName);
    }

    public void VectorText()
    {
        var levelName = "VectorText";
        Levels(levelName);
    }

    public void FirstTheory()
    {
        var sceneName = "FirstTheory";
        Levels(sceneName);
    }

    public void FirstLevelDescription()
    {
        var sceneName = "1LevelDescrip";
        Levels(sceneName);
    }

    public void FirstLevel()
    {
        var levelName = "FirstLevel";
        Levels(levelName);
    }

    public void SecondTheory()
    {
        var sceneName = "SecondTheory";
        Levels(sceneName);
    }

    public void SecondLevelDescription()
    {
        var sceneName = "2LevelDescrip";
        Levels(sceneName);
    }

    public void SecondLevel()
    {
        var levelName = "SecondLevel";
        Levels(levelName);
    }

    public void ThirdTheory1()
    {
        var levelName = "ThirdTheory1";
        Levels(levelName);
    }

    public void ThirdTheory2()
    {
        var levelName = "ThirdTheory2";
        Levels(levelName);
    }

    public void ThirdLevelDescription()
    {
        var levelName = "3LevelDescrip";
        Levels(levelName);
    }

    public void ThirdLevel()
    {
        var levelName = "ThirdLevel";
        Levels(levelName);
    }

    public void ForthTheory()
    {
        var levelName = "ForthTheory";
        Levels(levelName);
    }

    public void ForthLevelDescription()
    {
        var levelName = "4LevelDescrip";
        Levels(levelName);
    }

    public void ForthLevel()
    {
        var levelName = "ForthLevel";
        Levels(levelName);
    }

    public void Levels(string levelName)
    {
        Debug.Log(levelName);
        SceneManager.LoadScene(levelName);
        if (shipAdventure.Win())
            button.gameObject.SetActive(true);
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
