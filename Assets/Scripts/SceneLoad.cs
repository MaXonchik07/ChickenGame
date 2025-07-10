using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{   
    public void Two()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SetPlayerCount(2);
            SceneManager.LoadScene("LevelsOption");
        }
        else
        {
            Debug.LogError("GameManager не найден!");
        }
    }
    public void Three()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SetPlayerCount(3);
            SceneManager.LoadScene("LevelsOption");
        }
        else
        {
            Debug.LogError("GameManager не найден!");
        }
    }
        public void Four()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SetPlayerCount(4);   
            SceneManager.LoadScene("LevelsOption");
        }
        else
        {
            Debug.LogError("GameManager не найден!");
        }
    }
}
