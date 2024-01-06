using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TMP_InputField inputName;
    public void Start()
    {
        inputName.text = PlayerPrefs.GetString("currentName");
    }

    public void SetNewCurrentName()
    {
        PlayerPrefs.SetString("currentName", inputName.text);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }


    public void LoadLeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoardScene");
    }



    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
