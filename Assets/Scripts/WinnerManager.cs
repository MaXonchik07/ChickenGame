using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinnerManager : MonoBehaviour
{
    public TMP_Text winText;
    public GameObject WinnerMenuu;
    public Button nextLevel;
    public Button restartLevel;
    public Button levelsMenu;
    private bool gameStop = false;
    void Start()
    {
        WinnerMenuu.SetActive(false);
        nextLevel.onClick.AddListener(LoadNextLevel);
        restartLevel.onClick.AddListener(RestartLevel);
        levelsMenu.onClick.AddListener(ReturnToMainMenu);
    }
    void FixedUpdate()
    {
        if (gameStop) return;
        GameObject[] chickens = GameObject.FindGameObjectsWithTag("Player"); 
        if (chickens.Length == 1)
        {
            string winner = chickens[0].name.Replace("(Clone)", "").Replace("_", " "); 
            ShowWinner(winner);
            WinnerMenuu.SetActive(true);
            StopGame();
        }
        else if (chickens.Length == 0)
        {
            winText.text = "No one wins!";
            WinnerMenuu.SetActive(true);
            StopGame();
        }
    }
    void LoadNextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void RestartLevel()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void ShowWinner(string winner)
    {
        winText.text = $"{winner} wins!"; 
    }

    public void StopGame()
    {
        gameStop = true;
        Time.timeScale = 0f;
    }
}
