using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinnerManager : MonoBehaviour
{
    public TMP_Text winText;
    private bool gameStop = false;
    void FixedUpdate()
    {
        if (gameStop) return;
        GameObject[] chickens = GameObject.FindGameObjectsWithTag("Player"); 
        if (chickens.Length == 1)
        {
            string winner = chickens[0].name.Replace("(Clone)", "").Replace("_", " "); 
            ShowWinner(winner);
            StopGame();
        }
        else if (chickens.Length == 0)
        {
            winText.text = "No one wins!";
            StopGame();
        }
    }

    void ShowWinner(string winner)
    {
        winText.text = $"{winner} wins!"; 
    }

    void StopGame()
    {
        gameStop = true;
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
