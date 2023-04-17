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

    //��� ���������� ���� ��������

    //��������� ������� ������
    public void FullScreenToggle()
    {
        //fullscreen;
        Screen.fullScreen = !Screen.fullScreen;
    }


    //���� ������� ��������� ��������� ������ ����� slider "volume"
    //public GameSettings am;
    public void SetAudioVolume(float sliderValue)
    {
        //masterVolume ��� �������� ��� ������ ���������
        //����������������� ����� ���������� � 
        //am.SetFloat("masterVolume", sliderValue);
    }
}
