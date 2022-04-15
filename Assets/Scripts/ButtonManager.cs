using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private GameObject pausePanel,gameScreen;

    private void Start()
    {
        gameScreen = GameObject.Find("GameScreen");
        pausePanel = GameObject.Find("PausePanel");
        pausePanel.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        gameScreen.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        gameScreen.SetActive(true);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void MainMenü()
    {
        SceneManager.LoadScene(0);
    }
}
