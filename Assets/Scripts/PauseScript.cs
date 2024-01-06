using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public static bool isPaused;

    public GameObject inGameCanva;
    public GameStateScript gameState;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        
    }


    public void  PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        inGameCanva.SetActive(false);
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        inGameCanva.SetActive(true);
    }

    public void  GoToMainMenu()
    {
        Scores.UpdateScores(gameState.score);
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame()
    {
        Scores.UpdateScores(gameState.score);
        Time.timeScale = 1f;
        isPaused = false;
        Application.Quit();
    }
}
